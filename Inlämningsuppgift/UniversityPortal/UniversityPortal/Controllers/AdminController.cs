using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityPortal.Data;
using UniversityPortal.Models;

namespace UniversityPortal.Controllers
{
    [Authorize(Policy = "RequireAdminRole")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        private readonly IMapper _mapper;
        private readonly UniversityDbContext _context;

        public AdminController(UserManager<ApplicationUser> userManager, IPasswordHasher<ApplicationUser> passwordHasher, IMapper mapper, RoleManager<IdentityRole> roleManager, UniversityDbContext context)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();
            var userList = new List<UserViewModel>();


            foreach (var user in users)
            {
                userList.Add(_mapper.Map<UserViewModel>(user));
            }

            foreach (var user in userList)
 
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }

            return View(userList);
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Roles = _roleManager.Roles;
           return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user= new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //await _userManager.AddToRoleAsync(user, model.Role);
                    return RedirectToAction("Index");
                }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string firstname, string lastname, string password)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "E-postadressen får inte vara tom");

                if (!string.IsNullOrEmpty(firstname))
                    user.FirstName = firstname;
                else
                    ModelState.AddModelError("", "Förnamnet får inte vara tomt");

                if (!string.IsNullOrEmpty(lastname))
                    user.LastName = lastname;
                else
                    ModelState.AddModelError("", "Efternamnet får inte vara tomt");

                if (!string.IsNullOrEmpty(password))
                    user.PasswordHash = _passwordHasher.HashPassword(user, password);
                else
                    ModelState.AddModelError("", "Lösenordet får inte vara tomt ");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "Användare ej hittad");
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", _userManager.Users);
        }
    }
}
