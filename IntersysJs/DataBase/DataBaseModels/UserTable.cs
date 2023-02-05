using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntersysJs.DataBase.DataBaseModels
{
    public class UserTable
    {
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
