using Employee_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Employee_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using System.Linq;

namespace Employee_Management_System.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
      
        //Get employees:
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        //Get Employees/Create
        public IActionResult Create()
        {
            Console.WriteLine("Create method has been invoked.");
            return View();
        }

        //POST Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName" +
            ",Position,Salary,Department")] Employee employee)
        {
            Console.WriteLine("Create method has been invoked.");
            if (ModelState.IsValid)
            {
                Console.WriteLine("model valid...");

                _context.Add(employee);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));

                //how to indicate success submit
                //pop up indicating so
                //clear the input

            }
            // else {red pop up and don't clear data}
            return View(employee);
        }

        //GET Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var employee =await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        //POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,FirstName,LastName,Position,Salary,Department")]
        Employee employee)
        {
            if(id != employee.EmployeeId)
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
                catch (DBConcurrencyException) //?
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
                //return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        ////GET:Employee/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if(id == null)
        //    {
        //        return NotFound();
        //    }
        //    var employee = await _context.Employees
        //        .FirstOrDefaultAsync(m => m.EmployeeId == id);
        //    if(employee == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(employee);
        //}

        //POST:Employee/Delete/5
        //[HttpPost,ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult>DeleteConfirmed(int id)
        //{
        //    var employee = await _context.Employees.FindAsync(id);
        //    _context.Employees.Remove(employee);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if(employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return Json(new { success = true });
        }
        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
      
    }
}
