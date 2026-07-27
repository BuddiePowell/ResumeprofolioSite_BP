using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Test
{
    public class MockResumeRepository : IResumeRepository
    {
        #region Education Section

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

        #endregion


        #region Job Section

        public List<Job> GetAllJobEntries()
        {
            return new List<Job>();
        }

        public Task<Job> FindJobItemAsync(int id)
        {
            return Task.FromResult(new Job());
        }

        public Task<int> UpdateJobItem(int id, Job job)
        {
            return Task.FromResult(1);
        }

        public void AddJobItem(Job jobItem)
        {
        }

        public void RemoveJobItem(Job job)
        {
        }

        #endregion


        #region Skill Section

        public void AddSkillItem(Skill skillItem)
        {
        }

        public Task<Skill> FindSkillItemAsync(int id)
        {
            return Task.FromResult(new Skill());
        }

        public List<Skill> GetAllSkillEntries()
        {
            return new List<Skill>();
        }

        public void RemoveSkillItem(Skill skill)
        {
        }

        public Task<int> UpdateSkillItem(int id, Skill skill)
        {
            return Task.FromResult(1);
        }

        #endregion
    }
}