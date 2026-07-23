using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Test
{
    public class MockResumeRepository : IResumeRepository
    {
        public void AddEducationItem(Education educationItem)
        {
           
        }

        public bool AnyEducationItemsExist()
        {
            return true;
        }

        public Task<Education> FindEducationItemAsync(int id)
        {
            return Task.FromResult(new Education());
        }

        public List<Education> GetAllEducationEntries()
        {
            return new List<Education>();
        }

        public void RemoveEducationItem(Education education)
        {
            
        }

        public Task<int> UpdateEducationItem(int id, Education education)
        {
            return Task.FromResult(1);
        }


        #region Job Section
        public List<Job> GetAllJobEntries()
        {
            return new List<Job>();
        }
        #endregion

        private List<Job> _jobs = new List<Job>()
        {
            new Job
            {
                JobId = 1
                // Add your other Job properties here
            },
            new Job
            {
                JobId = 2
                // Add your other Job properties here
            }
        };

        public void AddEducationItem(Education educationItem)
        {
        }

        public bool AnyEducationItemsExist()
        {
            return true;
        }

        public Task<Education> FindEducationItemAsync(int id)
        {
            return Task.FromResult(new Education());
        }

        public List<Education> GetAllEducationEntries()
        {
            return new List<Education>();
        }

        public void RemoveEducationItem(Education education)
        {
        }

        public Task<int> UpdateEducationItem(int id, Education education)
        {
            return Task.FromResult(1);
        }

        #region Job Section

        public List<Job> GetAllJobEntries()
        {
            return _jobs;
        }

        public Task<Job> FindJobItemAsync(int id)
        {
            Job job = _jobs.FirstOrDefault(j => j.JobId == id);

            return Task.FromResult(job);
        }

        public Task<int> UpdateJobItem(int id, Job job)
        {
            Job existingJob = _jobs.FirstOrDefault(j => j.JobId == id);

            if (existingJob == null)
            {
                return Task.FromResult(0);
            }

            existingJob = job;

            return Task.FromResult(1);
        }

        public void AddJobItem(Job jobItem)
        {
            _jobs.Add(jobItem);
        }

        public void RemoveJobItem(Job job)
        {
            _jobs.Remove(job);
        }

        #endregion
    }
}
}
