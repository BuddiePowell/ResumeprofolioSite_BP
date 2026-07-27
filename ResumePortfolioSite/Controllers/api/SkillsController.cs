using Microsoft.AspNetCore.Mvc;
using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly IResumeRepository _resumeRepository;

        public SkillsController(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        // GET: api/Skills
        [HttpGet]
        public IEnumerable<Skill> GetSkills()
        {
            return _resumeRepository.GetAllSkillEntries();
        }

        // GET: api/Skills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Skill>> GetSkill(int id)
        {
            Skill skill = await _resumeRepository.FindSkillItemAsync(id);

            if (skill == null)
            {
                return NotFound();
            }

            return skill;
        }

        // PUT: api/Skills/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkill(int id, Skill skill)
        {
            if (id != skill.SkillId)
            {
                return BadRequest();
            }

            int updatedSkillId =
                await _resumeRepository.UpdateSkillItem(id, skill);

            if (updatedSkillId == -1)
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Skills
        [HttpPost]
        public ActionResult<Skill> PostSkill(Skill skill)
        {
            _resumeRepository.AddSkillItem(skill);

            return CreatedAtAction(
                nameof(GetSkill),
                new { id = skill.SkillId },
                skill);
        }

        // DELETE: api/Skills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            Skill skill =
                await _resumeRepository.FindSkillItemAsync(id);

            if (skill == null)
            {
                return NotFound();
            }

            _resumeRepository.RemoveSkillItem(skill);

            return NoContent();
        }
    }
}