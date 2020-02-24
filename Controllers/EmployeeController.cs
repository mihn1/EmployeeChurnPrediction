using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECP.Core.Common;
using ECP.Core.Entities;
using ECP.Core.Interfaces;
using ECP.Core.Utilities;
using ECP.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ECP.Web.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ECPDbContext _context;
        private readonly IPredictionService _predictionService;
        private readonly PredictionOptions _predictionOptions;
        private readonly string modelName;
        private readonly float thresHold;
        public EmployeeController(ECPDbContext context, IPredictionService predictionService, IOptions<PredictionOptions> predictionOptions)
        {
            _context = context;
            _predictionService = predictionService;
            _predictionOptions = predictionOptions.Value;
            modelName = _predictionOptions.ModelName;
            thresHold = _predictionOptions.Threshold;
        }

        // GET: Employee
        public async Task<IActionResult> Index(int? page)
        {
            var employees = await _context.Employee
                .Where(e => !e.IsTrained)
                .Select(e => e).ToListAsync();
            var predictedEmps = _predictionService.PredictEmployees(employees, modelName);
            return View(predictedEmps);
        }

        public async Task<IActionResult> Dashboard()
        {
            var employees = await _context.Employee.Where(e => !e.IsTrained).Select(e => e).ToListAsync();
            var predictedEmps = _predictionService.PredictEmployees(employees, modelName);
            var activeEmps = employees.Where(e => !e.Attrition);

            ViewData["ActiveEmployees"] = activeEmps.Count();
            ViewData["AttritionEmployees"] = employees.Except(activeEmps).Count();
            ViewData["RiskyRate"] = Math.Round(predictedEmps.Where(e => !e.Employee.IsTrained && !e.Employee.Attrition && e.Prediction.Probability >= thresHold).Count() * 100.00 / activeEmps.Count(), 2);
            ViewData["MostRiskDepartment"] = predictedEmps.Where(p => !p.Employee.Attrition)
                .GroupBy(
                p => p.Employee.Department,
                (key, group) => new { department = key, riskRate = group.Where(g => g.Prediction.Probability >= thresHold).Count() * 1.00 / group.Count() }).OrderByDescending(d => d.riskRate).FirstOrDefault().department;
          
            return View(predictedEmps);
        }

        // GET: Employee/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee employee = new Employee();
            return View(employee);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }




        [HttpGet]
        public async Task<JsonResult> PopulationAttritionRate()
        {
            var employees = await _context.Employee.Where(e => !e.IsTrained && !e.Attrition).Select(e => e).ToListAsync();
            var predictedEmps = _predictionService.PredictEmployees(employees, modelName);

            var data = predictedEmps
                .GroupBy(
                p => p.Employee.Department,
                (key, group) => new { department = key, attritionRate = Math.Round(group.Where(g => g.Prediction.Probability >= thresHold).Count() * 100.00 / group.Count(), 2) })
                .ToList();

            return Json(data);
        }

        [HttpGet]
        public async Task<JsonResult> PopulationDepartmentCount()
        {
            var employees = await _context.Employee.Where(e => !e.IsTrained && !e.Attrition).Select(e => e).ToListAsync();
            var predictedEmps = _predictionService.PredictEmployees(employees, modelName);

            var data = predictedEmps
                .GroupBy(
                p => p.Employee.Department,
                (key, group) => new { department = key, employeeCount = group.Count() })
                .ToList();

            return Json(data);
        }

        [HttpGet]
        public async Task<JsonResult> GetTopEmployees()
        {
            var employees = await _context.Employee.Where(e => !e.IsTrained && !e.Attrition).Select(e => e).ToListAsync();
            var predictedEmps = _predictionService.PredictEmployees(employees, modelName);
            var data = predictedEmps
                .OrderByDescending(p => p.Prediction.Probability)
                .Take(10);

            return Json(new { data });
               
        }
    }
}