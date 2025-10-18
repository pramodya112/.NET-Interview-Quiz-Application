using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Quize_app.Data;
using Quize_app.Models;

namespace Quize_app.Controllers
{
    public class QuizController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Home()
        {
            return View();
        }

    public IActionResult Index(string candidateName)
        {
            ViewBag.CandidateName = candidateName;
            var questions = _context.Questions.OrderBy(q => Guid.NewGuid()).Take(5).ToList();
            return View(questions);
        }

        [HttpPost]
        public IActionResult Submit(List<string> answers)
        {
            var questions = _context.Questions.OrderBy(q => Guid.NewGuid()).Take(answers.Count).ToList();
            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                string correct = questions[i].correctAnswer;
                string selected = answers[i] switch

                {
                    "A" => questions[i].optionA,
                    "B" => questions[i].optionB,
                    "C" =>questions[i].optionC,
                    "D" => questions[i].optionD,

                    _ => ""

                };

                if (selected == correct) score ++;
            }

            TempData["Score"] = score;
            TempData["TotalQuestions"] = questions.Count;
            return RedirectToAction("Result");
        }

        public IActionResult Result()
        {
            ViewBag.Score = TempData["Score"];
            ViewBag.TotalQuestions = TempData["TotalQuestions"] ?? 0;
            ViewBag.Error = TempData["Error"];
            ViewBag.Error = TempData["Error"];
            return View();
        }

    }
}
