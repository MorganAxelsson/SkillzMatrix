using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data.Entities
{
    public class UserSkillz
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Users User { get; set; }
        public int UserId { get; set; }
        public Skillz Skillz { get; set; }
        public int SkillzId { get; set; }
        public Levels Levels { get; set; }
        public int LevelsId { get; set; }
    }
}
