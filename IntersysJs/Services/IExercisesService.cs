using IntersysJs.DataBase.DataBaseModels;

namespace IntersysJs.Services
{
	public interface IExercisesService
	{
		public Task<UserTable> GetByIdAsync(int id);
		public Task<IEnumerable<UserTable>> GetUsersAsync();
	}
}
