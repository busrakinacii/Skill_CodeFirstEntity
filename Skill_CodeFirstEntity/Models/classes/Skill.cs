using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.classes
{
    public class Skill
    {
        [Key]
        public int ID { get; set; }
        public string Explanation { get; set; }
        public byte Value { get; set; }
    }
}