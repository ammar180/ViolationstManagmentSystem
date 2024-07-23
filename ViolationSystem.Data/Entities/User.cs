using System.ComponentModel.DataAnnotations;

namespace ViolationSystem.Data.Entities
{
	public class User
	{
		[Key]
        public int Id { get; set; }
        public string UserName { get; set; }
		public string Password { get; set; }
    }
}
