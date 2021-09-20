using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectsRepository _projectsRepository;

        public HomeController(IProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Projects";

            IEnumerable<Project> projects = _projectsRepository.GetAllProjects();

            return View(projects);
        }
    }
}
