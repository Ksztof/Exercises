using IntersysJs.DataBase.DataBaseModels;
using Microsoft.EntityFrameworkCore;

namespace IntersysJs.Repositories
{
    public class ExercisesRepository : Repository, IExercisesRepository 
    {
        public ExercisesRepository()
        {
        }

		public async Task<UserTable> GetbyId(int id)
        {
            return await ExercisesDb.Users.FirstAsync(x => x.Id == id);
        }
    }
}
