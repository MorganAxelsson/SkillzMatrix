﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data.Entities
{
    public class Teams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string TeamName { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }

        public virtual ICollection<UserInTeams> UserInTeams { get; set; } = new List<UserInTeams>();
    }
}
