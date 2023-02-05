using IntersysJs.DataBase.DataBaseModels;
using IntersysJs.FormModels;

namespace IntersysJs.Services
{
	public interface IExercisesService
	{
		 Task<UserTable> GetByIdAsync(int id);
		 Task<IEnumerable<UserTable>> GetUsersAsync();
		 Task<bool> AddNewUserAsync(AddUserForm form);
		
	}
}
