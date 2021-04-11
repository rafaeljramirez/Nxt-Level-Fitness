using Microsoft.AspNetCore.Mvc;
using Nxt_Level_Fitness.Models;


namespace Nxt_Level_Fitness.Controllers
{
    public class WeightWorkoutController : Controller
    {
        // M e t h o d s

        // C r e a t e

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(WeightWorkout w)
        {
            w.Id = 1;
            w.UserId = 1;

            if (ModelState.IsValid)
            {
                return RedirectToAction("WeightWorkoutDetails", w);
            }

            return RedirectToAction("WeightWorkoutDetails", w);
            //return View(w);
        }


        [HttpGet]
        public IActionResult EditWeightWorkout(int id)
        {
            // fake information
            WeightWorkout ww = new WeightWorkout();
            ww.Id = id;
            ww.WeightWorkouts = "Chest";
            ww.Calories = 600;
            return View(ww);
        }

        [HttpPost]
        public IActionResult EditWeightWorkout(WeightWorkout updatedWeightWorkout)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("WeightWorkoutDetails", updatedWeightWorkout);
            }

            return View(updatedWeightWorkout);
        }

        public IActionResult WeightWorkoutDetails(WeightWorkout w)
        {
            return View(w);
        }
        // R e a d

        // U p d a t e

        // D e l e t e
    }
}
