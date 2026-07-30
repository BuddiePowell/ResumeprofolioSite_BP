using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Models
{
   
        public class Job
        {
            public int JobId { get; set; }

            public string Company { get; set; }

            public string Position { get; set; }
            public int StartYear { get; set; }

            public int? EndYear { get; set; }

            public string Description { get; set; }
    }
    }