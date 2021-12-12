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
        public IActionResult Result(int id, int? pscore)
        {
            Student s = Database.GetById(id);
            if (pscore != null) s.Result += (int)pscore;
            return View(s);
        }
        [Route("/Quiz/{id}/{num}/{pscore}")]
        public IActionResult Index(int id, int num = 0, int pscore = 0)
        {
            Student s = Database.GetById(id);
            s.Result += pscore;
            try
            {
                Question q = Questions.At(num);
                q.num = num;
                return View("Quiz",new KeyValuePair<Question, Student>(q, s));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
