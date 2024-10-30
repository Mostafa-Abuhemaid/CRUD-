using Microsoft.AspNetCore.Mvc;
using MVC_Project.BLL.Interface;
using MVC_Project.DAL.Model;
using System.ComponentModel;

namespace MVC_Project.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var department = _departmentRepository.GetAll();
            return View(department);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
           if(ModelState.IsValid)
            {
                _departmentRepository.Add(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
        public IActionResult Details(int? id )
        {
            if (id == null)
                return BadRequest();
           var department=_departmentRepository.GetById(id.Value);
            return View(department);
          
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();
            var department = _departmentRepository.GetById(id.Value);
            return View(department);

        }
        [HttpPost]
        public IActionResult Update(Department department)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _departmentRepository.Update(department);
                    RedirectToAction(nameof(Index));
                }
                catch(System.Exception e) 
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                }

            }
            return View(department);

        }
    }
    
}
