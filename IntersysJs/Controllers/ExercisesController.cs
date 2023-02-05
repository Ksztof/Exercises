using IntersysJs.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IntersysJs.Controllers
{
    [Route("/Intersys")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {

		[HttpPost]
        [Route("/Intersys/FirstExercise")]
        public IActionResult FirstExercise([FromBody] FirstExerciseModel data)
        {
            var doubleUserInput = data.UserInput * 2;
			var responseData = new { doubleUserInput = doubleUserInput };

			return Ok(JsonConvert.SerializeObject(responseData));
		}


    }
}
