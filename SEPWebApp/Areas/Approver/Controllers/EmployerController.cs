using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess.Repository.IRepository;
using SEP.Utility;
using System.Linq;
using System;
using System.Collections.Generic;
using SEP.Models;
using SEP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SEPWebApp.Areas.Approver.Controllers
{
    [Area("Approver")]
    [Authorize(Roles = SD.Role_Approver)]
    //[Authorize(Roles = SD.Role_Approver)]
    public class EmployerController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public EmployerController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var employerVM = new EmployerVM()
            {
                ApplicationUserList = _unitOfWork.ApplicationUser.GetAll(),
                EmployerList=_unitOfWork.Employer.GetAll(),
                StatusList = _unitOfWork.Status.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

            return View(employerVM);
        }

        //GET
        public IActionResult Upsert(string? id)
        {

            EmployerVM EmployerVM = new()
            {
                ApplicationUser = new(),
                Employer = new(),
                BusinessTypeList = _unitOfWork.BusinessType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                StatusList = _unitOfWork.Status.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })

            };


                //update Employer
                EmployerVM.ApplicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == id);
                EmployerVM.Employer = _unitOfWork.Employer.GetFirstOrDefault(u => u.Id == id);
                return View(EmployerVM);


        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployerVM obj)
        {
            //EmployerVM employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.Id == obj.ApplicationUser);

            if (ModelState.IsValid)
            {
                if (obj.Employer.Id==null)
                {
                    _unitOfWork.Employer.Add(obj.Employer);
                }
                else
                {
                    _unitOfWork.Employer.Update(obj.Employer);
                }
                _unitOfWork.Save();
                TempData["success"] = "Employer Profile status updated";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        /*        #region API CALLS
                [HttpGet]
                public IActionResult GetAll()
                {
                    var EmployerList = _unitOfWork.Employer.GetAll(includeProperties: "Status");
                    var UserList = _unitOfWork.ApplicationUser.GetAll();
                    *//*            var combinedList = _unitOfWork.Concat(EmployerList, UserList);*//*
                    return Json(new { data = EmployerList });
                }
                #endregion*/


    }
}