using IntersysJs.DataBase.DataBaseModels;
using IntersysJs.Repositories;

namespace IntersysJs.Services
{
    public class ExercisesService : IExercisesService
    {
		private ExercisesRepository _exercisesRepository = null;
		private ExercisesRepository exercisesRepository
		{
			get
			{
				if (_exercisesRepository == null)
				{
					_exercisesRepository = new ExercisesRepository();
				}
				return _exercisesRepository;
			}
		}

		public ExercisesService()
		{
		}

		public async Task<UserTable> GetByIdAsync(int id)
        {
            return await exercisesRepository.GetbyIdAsync(id);	
        }

		public async Task<IEnumerable<UserTable>> GetUsersAsync()
		{
			return await exercisesRepository.GetUsersAsync();
		}
	}
}
