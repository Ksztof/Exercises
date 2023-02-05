namespace IntersysJs.DataBase.DataBaseModels
{
	public abstract class Repository
	{
		private IntersysDb _db = null;

		public virtual IntersysDb ExercisesDb
		{
			get
			{
				if (_db == null)
				{
					_db = new IntersysDb();
				}

				return _db;
			}
		}
	}
}
