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
        async public Task<IActionResult> Table()
        {
            return View("Table", await Database.RequestTable());
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/send")]
        public IActionResult Send(Student student)
        {
            Database.Send(student.Name, student.Result);
            return Redirect("/Home/Table");
        }
        [HttpPost("/Sendf")]
        public IActionResult Sendf(string name)
        {
            return this.Send(new Student() { Name=name, Result=(int)(Database.result / 24 * 100) });
        }
        [HttpGet("/leaderboardsxxx")]
        async public Task<IActionResult> LeaderBoardsx()
        {
            return Json(await Database.RequestTable());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Download()
        {
            FileStream f = new FileStream("C:\\Users\\User\\Desktop\\Executable.zip", FileMode.Open, FileAccess.Read);
            return File(f, "application/zip", "Application.Zip");
        }
    }
}
