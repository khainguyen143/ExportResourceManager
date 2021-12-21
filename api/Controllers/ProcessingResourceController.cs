using API.Data;
using ExportResourceManager.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ExportResourceManager.Controller
{
    [Route("api/processing")]
    [ApiController]
    public class ProcessingResourceController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ProcessingResourceController( ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAsync ()
        {
            var query = await _context.IntergratedResources
                .Include(e => e.EditResources).ThenInclude(e => e.PrimordialResources)
                .ToListAsync();
            var exportResourceManagerDto = query.Select(e => new ExportResourceManagerDto()
                {
                    ResourceFileId = e.ResourceFileId,
                    Description = e.Description,
                    Title = e.Title,
                    EditingSoftware = e.EditingSoftware,
                    UsedByUrls = e.UsedByUrls,
                    ResourceDtos = e.EditResources.Select(a => new ResourceDto()
                    {
                        ResourceFileId = a.PrimordialResources.ResourceFileId,
                        Description = a.PrimordialResources.Description,
                        Name = a.PrimordialResources.Title,
                        StartTime = a.StartTime,
                        EndTime = a.EndTime,
                    }).ToList(),
                }).ToList();

            return Ok(exportResourceManagerDto);
        }
    }
}
