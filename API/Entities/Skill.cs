namespace Skillustrator.Api.Entities
{
    public class Skill : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Person> People { get; set; }
    }
}