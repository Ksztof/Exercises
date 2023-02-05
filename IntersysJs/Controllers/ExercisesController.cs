using IntersysJs.DataBase.DataBaseModels;
using IntersysJs.Models;
using IntersysJs.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IntersysJs.Controllers
{
    [Route("/Intersys")]
    [ApiController]
    public class ExercisesController : ControllerBase 
    {
		private IExercisesService _exercisesService;
		public ExercisesController(IExercisesService exercisesService)
		{
			this._exercisesService = exercisesService; 
		}

		[HttpPost]
        [Route("/Intersys/ThirdExercise")]
        public IActionResult ThirdExercise([FromBody] FirstExerciseModel data)
        {
            var doubleUserInput = data.UserInput * 2;
			var responseData = new { doubleUserInput = doubleUserInput };

			return new JsonResult(responseData);
		}

		[HttpPost]
        [Route("/Intersys/FourthExercise")]
		public async Task<IActionResult> FourthExercise([FromBody] FirstExerciseModel data)
		{
			var user = await _exercisesService.GetByIdAsync(data.UserInput);
			return new JsonResult(user);
		}

		[HttpGet]
		[Route("/Intersys/FifthExercise")]
		public async Task<IActionResult> FifthExercise()
		{
			var users = await _exercisesService.GetUsersAsync();
			return new JsonResult(users);
		}


	}
}
