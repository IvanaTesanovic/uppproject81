using NPoco;

namespace Data.Entities
{
    [PrimaryKey("Id")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}