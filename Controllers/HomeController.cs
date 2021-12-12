#nullable enable
using HistoryServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data.SqlClient;
using System.IO;

namespace HistoryServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            if (logger != null)
            _logger = logger;
        }
        async public Task<IActionResult> Table(int? n)
        {
            if (n == null)
                try
                {
                    return View("Table", await Database.RequestTable());
                }
                catch (SqlException e)
                {
                    return View("ServerError", e);
                }
            else
                return Json(await Database.RequestTable());
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", null);
        }
        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (!ModelState.IsValid)
            {
                string err = "";
                foreach (var e in ModelState["Name"].Errors)
                    err += e.ErrorMessage + "\n";
                return View("Index", err);
            }
            Database.online.Add(student);
            student.Id = Database.online.IndexOf(student);
            return Redirect($"/Quiz/{student.Id}/0/0");
        }
        [HttpPost("/send")]
        public IActionResult Send(string name, int result)
        {
            try
            {
                Database.Send(name, result);
                return Redirect("/Home/Table");
            }
            catch (SqlException e)
            {
                return View("ServerError", e);
            }
        }
        [HttpPost]
        public IActionResult SendById(int id)
        {
            Database.Send(id: id);
            return Redirect("/Home/Table");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Download()
        {
            return File(new MemoryStream(Resource.Executable), "application/zip", "Application.Zip");
        }
    }
}
