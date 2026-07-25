using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System;
using System.Collections.Generic;
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

        public Task<Job> FindJobItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateJobItem(int id, Job job)
        {
            throw new NotImplementedException();
        }

        public void AddJobItem(Job jobItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveJobItem(Job job)
        {
            throw new NotImplementedException();
        }
        #endregion

        private List<Job> _jobs = new List<Job>()
{
    new Job
    {
        JobId = 1,
        Company = "Hy-Vee"
    },
    new Job
    {
        JobId = 2,
        Company = "Target"
    }
};
    }
}
