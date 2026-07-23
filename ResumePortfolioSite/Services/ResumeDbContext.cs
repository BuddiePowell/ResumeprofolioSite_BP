using Microsoft.EntityFrameworkCore;
using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Services
{
    public class ResumeDbContext : DbContext, IResumeRepository
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options)
            : base(options)
        {

        }

        DbSet<Education> Educations { get; set; }
        DbSet<Job> Jobs { get; set; }

        #region Education methods
        public List<Education> GetAllEducationEntries()
        {
            return Educations.ToList();
        }

        public bool AnyEducationItemsExist()
        {
            return Educations.Any();
        }

        public void AddEducationItem(Education educationItem)
        {
            Educations.Add(educationItem);
            SaveChanges();
        }

        public async Task<int> UpdateEducationItem(int id, Education education)
        {
            Entry(education).State = EntityState.Modified;

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationItemExists(id))
                {
                    return -1;
                }
                else
                {
                    throw;
                }
            }

            return education.EducationId;
        }

        public async Task<Education> FindEducationItemAsync(int id)
        {
            return await Educations.FindAsync(id);
        }

        public void RemoveEducationItem(Education education)
        {
            Educations.Remove(education);
            SaveChanges();
        }

        private bool EducationItemExists(int id)
        {
            return Educations.Any(e => e.EducationId == id);
        }

        public List<Job> GetAllJobEntries()
        {
            return Jobs.ToList();
        }

        internal bool AnyJobItemsExist()
        {
            return Jobs.Any();
        }

        public void AddJobItem(Job jobItem)
        {
            Jobs.Add(jobItem);
            SaveChanges();
        }

        public async Task<Job> FindJobItemAsync(int id)
        {
            return await Jobs.FindAsync(id);
        }

        public async Task<int> UpdateJobItem(
            int id,
            Job job)
        {
            Entry(job).State = EntityState.Modified;

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobItemExists(id))
                {
                    return -1;
                }

                throw;
            }

            return job.JobId;
        }

        public void RemoveJobItem(Job job)
        {
            Jobs.Remove(job);
            SaveChanges();
        }

        private bool JobItemExists(int id)
        {
            return Jobs.Any(job => job.JobId == id);
        }

        #endregion
    }
}
