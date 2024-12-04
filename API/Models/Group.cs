namespace API.Models
{
	public class Group
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		public Guid SpecialityId { get; set; }
		public Speciality? Speciality { get; set; }

		// Куратор
		public Guid PrepId { get; set; }
		public Prep? Prep { get; set; }


		public List<User> Users { get; set; } = new();
	}
}
