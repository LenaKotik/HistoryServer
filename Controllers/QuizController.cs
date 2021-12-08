using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryServer.Models;

namespace HistoryServer.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Result()
        {
            return View(Database.result);
        }
        [Route("/Quiz/{num}/{pscore}")]
        public IActionResult Index(int num = 0, int pscore = 0)
        {
            Database.result += pscore;
            try
            {
                Question q = Questions.At(num);
                q.num = num;
                return View("Quiz",q);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
