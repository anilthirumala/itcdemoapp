using CoreMVCDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDemo.Controllers
{
    public class TaskController : Controller
    {
        ITaskRepository taskRepository;
        public TaskController(ITaskRepository rep)
        {
            this.taskRepository = rep;
           
        }
         public IActionResult Add()
        {
            return View();
        }
        public IActionResult Create(Models.Task t) {
            taskRepository.AddTask(t);
             
           return RedirectToAction("Add");
        }
        public IActionResult Show()
        {
            return View(taskRepository.GetAllTasks());
        }
        public IActionResult Edit(int id)
        {
           var result = taskRepository.GetAllTasks().Where(t=>t.Id == id).FirstOrDefault();
            return View(result);
        }
    }
}
