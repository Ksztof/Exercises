using IntersysJs.DataBase.DataBaseModels;
using Microsoft.EntityFrameworkCore;

namespace IntersysJs.Repositories
{
    public class ExercisesRepository : Repository, IExercisesRepository 
    {
        public ExercisesRepository()
        {
        }

		public async Task<UserTable> GetbyIdAsync(int id)
        {
            return await ExercisesDb.Users.FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<UserTable>> GetUsersAsync()
        {
            var users = await ExercisesDb.Users.ToListAsync();
            return users;
		}
    }
}
