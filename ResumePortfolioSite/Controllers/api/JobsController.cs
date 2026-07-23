using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;

namespace ResumePortfolioSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IResumeRepository _resumeRepository;

        public JobsController(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        // GET: api/Jobs
        [HttpGet]
        public IEnumerable<Job> GetJobs()
        {
            return _resumeRepository.GetAllJobEntries();
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJob([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Job job = await _resumeRepository.FindJobItemAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        // PUT: api/Jobs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob(
            [FromRoute] int id,
            [FromBody] Job job)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != job.JobId)
            {
                return BadRequest();
            }

            int resultId =
                await _resumeRepository.UpdateJobItem(id, job);

            if (resultId == -1)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Jobs
        [HttpPost]
        public IActionResult PostJob([FromBody] Job job)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _resumeRepository.AddJobItem(job);

            return CreatedAtAction(
                "GetJob",
                new { id = job.JobId },
                job);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Job job =
                await _resumeRepository.FindJobItemAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            _resumeRepository.RemoveJobItem(job);

            return Ok(job);
        }
    }
}