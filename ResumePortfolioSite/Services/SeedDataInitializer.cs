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
                jobItem.Position = "Team Member";
                jobItem.StartYear = 2022;
                jobItem.EndYear = 2023;
                jobItem.Description = "Provided customer service and assisted with daily store operations.";

                _resumeDbContext.AddJobItem(jobItem);


                Job anotherJobItem = new Job();
                anotherJobItem.Company = "Walmart";
                anotherJobItem.Position = "Associate";
                anotherJobItem.StartYear = 2021;
                anotherJobItem.EndYear = 2022;
                anotherJobItem.Description = "Assisted customers and maintained organized merchandise areas.";

                _resumeDbContext.AddJobItem(anotherJobItem);


                Job anotherJobItem2 = new Job();
                anotherJobItem2.Company = "Festival Foods";
                anotherJobItem2.Position = "Team Member";
                anotherJobItem2.StartYear = 2023;
                anotherJobItem2.Description = "Supports customers and performs daily store responsibilities.";

                _resumeDbContext.AddJobItem(anotherJobItem2);
            }

            // checks to see if theres any skill records in the skills table
            if (!_resumeDbContext.AnySkillItemsExist())
            {
                Skill skillItem = new Skill();
                skillItem.Name = "C#";
                skillItem.Category = "Programming Language";
                skillItem.ExperienceLevel = "Intermediate";

                _resumeDbContext.AddSkillItem(skillItem);


                Skill anotherSkillItem = new Skill();
                anotherSkillItem.Name = "Java";
                anotherSkillItem.Category = "Programming Language";
                anotherSkillItem.ExperienceLevel = "Intermediate";

                _resumeDbContext.AddSkillItem(anotherSkillItem);


                Skill anotherSkillItem2 = new Skill();
                anotherSkillItem2.Name = "SQL";
                anotherSkillItem2.Category = "Database";
                anotherSkillItem2.ExperienceLevel = "Intermediate";

                _resumeDbContext.AddSkillItem(anotherSkillItem2);
            }
        }
    }
}