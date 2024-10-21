using System.ComponentModel.DataAnnotations;

namespace KisiselSitem.DAL.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string? Title { get; set; }
        public int Value { get; set; }
    }
}
