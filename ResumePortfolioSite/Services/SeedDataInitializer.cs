using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Services
{
    public class SeedDataInitializer
    {
        private ResumeDbContext _resumeDbContext;

        public SeedDataInitializer(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }

        public void Seed()
        {
            // This is where we can add data to the database

         
            if (!_resumeDbContext.AnyEducationItemsExist())
            {
                Education educationItem = new Education();
                educationItem.SchoolName = "Madison College";
                educationItem.StartYear = 2020;
                educationItem.StartMonth = "September";
                educationItem.Degree = "AS, Web Software Development";

                _resumeDbContext.AddEducationItem(educationItem);

                Education anotherEducationItem = new Education();
                anotherEducationItem.SchoolName = "Edgewood College";
                anotherEducationItem.StartYear = 2022;
                anotherEducationItem.StartMonth = "September";
                anotherEducationItem.Degree = "BA, Business Administration";

                _resumeDbContext.AddEducationItem(anotherEducationItem);

                Education anotherEducationItem2 = new Education();
                anotherEducationItem2.SchoolName = "University of Wisconsin–Madison";
                anotherEducationItem2.StartYear = 2024;
                anotherEducationItem2.StartMonth = "September";
                anotherEducationItem2.Degree = "BS, Computer Sciences";

                _resumeDbContext.AddEducationItem(anotherEducationItem2);
            
        }

            // Check for Job records
            if (!_resumeDbContext.AnyJobItemsExist())
            {
                Job jobItem = new Job();
                jobItem.Company = "Target";
                _resumeDbContext.AddJobItem(jobItem);

                Job anotherJobItem = new Job();
                anotherJobItem.Company = "Amazon";
                _resumeDbContext.AddJobItem(anotherJobItem);

                Job anotherJobItem2 = new Job();
                anotherJobItem2.Company = "UW Health";
                _resumeDbContext.AddJobItem(anotherJobItem2);
            }

        }
    }
}
