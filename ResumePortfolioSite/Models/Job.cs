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
        }
    }