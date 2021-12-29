using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkManager.Entity;
using WorkManager.Service.Abstract;

namespace WorkManager.API.Controllers
{
    [ApiController]
    [Route("/[Controller]")]
    public class WorkController : ControllerBase
    {
        private IService service;

        public WorkController(IService _service)
        {
            this.service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var entities = await service.getAll();
            if (entities != null)
            {
                return Ok(entities);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(int id)
        {
            var entities = await service.getById(id);
            if (entities != null)
            {
                return Ok(entities);
            }
            return NotFound();
        }


        [HttpGet("/succeeded")]
        public async Task<IActionResult> getBySucceeded()
        {
            var entities = await service.getBySucceeded();
            if (entities.Count() > 0)
            {
                return Ok(entities);
            }
            return NotFound();
        }

        [HttpGet("/daily")]
        public async Task<IActionResult> getByDaily()
        {
            var entities = await service.getByDaily();
            if (entities.Count() > 0)
            {
                return Ok(entities);
            }
            return NotFound();
        }

        [HttpGet("/weekly")]
        public async Task<IActionResult> getByWeekly()
        {
            var entities = await service.getByWeekly();
            if (entities.Count() > 0)
            {
                return Ok(entities);
            }
            return NotFound();
        }

        [HttpGet("/monthly")]
        public async Task<IActionResult> getByMonthly()
        {
            var entities = await service.getByMonthly();
            if (entities.Count() > 0)
            {
                return Ok(entities);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> createWork(Work work)
        {
            await service.create(work);
            return Ok(work);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateWork(int id, Work work)
        {
            if (id != work.Id)
            {
                return BadRequest();
            }
            await service.update(work);
            return Ok(work);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteWork(int id)
        {
            var work = await service.getById(id);
            if (work == null)
            {
                return NotFound();

            }
            await service.delete(work);
            return Ok(work);
        }
    }
}