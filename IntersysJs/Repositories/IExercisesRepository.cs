using IntersysJs.DataBase.DataBaseModels;

namespace IntersysJs.Repositories
{
    public interface IExercisesRepository
    {
        Task<UserTable> GetbyIdAsync(int id);
		Task<IEnumerable<UserTable>> GetUsersAsync();

	}
}
