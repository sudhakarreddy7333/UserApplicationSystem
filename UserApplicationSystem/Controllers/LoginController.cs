﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplicationSystem.BusinessModels;
using UserApplicationSystem.UserAccessService;

namespace UserApplicationSystem.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginUserModel loginDetails)
        {
            if (ModelState.IsValid)
            {
                UserAccessServiceClient client = new UserAccessServiceClient();
                UserAccessData retrievedResult = new UserAccessData();
                var response = client.AuthenticateUser(new UserAccessData() {
                    UserName = loginDetails.UserName,
                    Password = loginDetails.Password
                });
                if (response.Message == ConstantsModel.SuccessMessage)
                {
                    retrievedResult = response.Data;
                    return RedirectToAction("index", "home", new { loggedIn = retrievedResult.UserType.ToString() , userId = retrievedResult.UserId});
                }
                if (response.Message == "NoUserFound")
                {
                    ViewBag.ErrorMessage = "Incorrect username or passoword";
                    return View();
                }
                
                else return RedirectToAction("index", "login");
            }
            else
                return RedirectToAction("index", "login");

        }
    }
}