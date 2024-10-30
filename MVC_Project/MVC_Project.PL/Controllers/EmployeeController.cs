using Microsoft.AspNetCore.Mvc;
using MVC_Project.BLL.Interface;
using MVC_Project.BLL.Repository;
using MVC_Project.DAL.Model;

namespace MVC_Project.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            var employee = _employeeRepository.GetAll();
            //ViewData
            ViewData["massage"] = "Hello form view data";
            ViewBag.massage2 = "Helow from view Bag";
            return View(employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var department = _employeeRepository.GetById(id.Value);
            return View(department);

        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();
            var department = _employeeRepository.GetById(id.Value);
            return View(department);

        }
        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _employeeRepository.Update(employee);
                    RedirectToAction(nameof(Index));
                }
                catch (System.Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                }

            }
            return View(employee);

        }
    }
}
