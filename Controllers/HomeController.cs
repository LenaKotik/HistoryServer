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
using System;
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
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/send")]
        public IActionResult Send(string name, int? result)
        {
            try
            {
            Database.Send(name, (result == null) ? Database.result : (int)result);
            return Redirect("/Home/Table");
            }
            catch (SqlException e)
            {
                return View("ServerError", e);
            }
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
