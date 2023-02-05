using IntersysJs.DataBase.DataBaseModels;

namespace IntersysJs.Repositories
{
    public interface IExercisesRepository
    {
        Task<UserTable> GetbyId(int id);
    }
}
