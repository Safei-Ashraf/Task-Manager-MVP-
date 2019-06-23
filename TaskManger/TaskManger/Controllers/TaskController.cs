using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManger.Models;

namespace TaskManger.Controllers
{
    public class TaskController : Controller
    {
        finalprojectEntities Context = new finalprojectEntities();
        // GET: Task
        [HttpGet]
        public ActionResult Create()
        {
            
            ViewBag.Categorylist = new SelectList(Context.TaskCategories, "ID", "Name");
           
           
            var GetPrimarySubCategoryList = Context.TaskPrimarySubCategories.ToList();
            SelectList PrimarySubCategoryList1 = new SelectList(GetPrimarySubCategoryList, "ID", "Name");
            if (GetPrimarySubCategoryList != null)
            {
                ViewBag.PrimarySubCategoryList = PrimarySubCategoryList1;
            }

            var GetSecondarySubCategoryList = Context.TaskSecondarySubCategories.ToList();
            SelectList SecondarySubCategoryList1 = new SelectList(GetSecondarySubCategoryList, "ID", "Name");
            if (GetSecondarySubCategoryList != null)
            {
                ViewBag.SecondarySubCategoryList = SecondarySubCategoryList1;
            }

            var GetPriorityList = Context.Priorities.ToList();
            SelectList Prioritylist1 = new SelectList(GetPriorityList, "ID", "Name");
            if (GetPriorityList != null)
            {
                ViewBag.PriorityList = Prioritylist1;
            }

            return View();
        }
        [HttpPost]
        public ActionResult Create(Task Task1)
        {
            Task1.CreatedDate = DateTime.Now;
            Task1.CreatedBy = 1;
            Context.Tasks.Add(Task1);
            Context.SaveChanges();
            return View();
        }
    }
}