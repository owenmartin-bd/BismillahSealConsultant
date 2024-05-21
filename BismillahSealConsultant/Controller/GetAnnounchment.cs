using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BismillahSealConsultant.DataContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BismillahSealConsultant.Controllers
{
    [Route("getData")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {


        [HttpGet]
        public async Task<IActionResult> GetLatestAnnouncement()
        {
            using (sealConsultantContext _context = new sealConsultantContext())
            {
                var latestAnnouncement = await _context.Announcements
                  .OrderByDescending(a => a.Date)
                  .FirstOrDefaultAsync();

                if (latestAnnouncement == null)
                {
                    return NotFound("No announcement found.");
                }



                return Ok(
                    new
                    {
                        title = latestAnnouncement.Title,
                        details = latestAnnouncement.Details,
                    }

                    );
            }

        }
    }
}
