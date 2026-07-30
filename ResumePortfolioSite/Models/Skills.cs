using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Models
{
    public class Skill
    {
       
            public int SkillId { get; set; }

            public string Name { get; set; }

            public string Category { get; set; }

            public string ExperienceLevel { get; set; }
    }
    }
