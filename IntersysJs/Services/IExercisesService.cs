using IntersysJs.DataBase.DataBaseModels;

namespace IntersysJs.Services
{
    public interface IExercisesService
    {
        public Task<UserTable> GetById(int id);
    }
}
