using BismillahSealConsultant.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BismillahSealConsultant.Controller
{
    [Route("audioannouncement")]
    [ApiController]
    public class AudioAnnouncement : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLatestAnnouncement()
        {
            using (sealConsultantContext _context = new sealConsultantContext())
            {
                var latestAnnouncement = await _context.AudioAnouncements
                  .OrderByDescending(a => a.DateTime)
                  .FirstOrDefaultAsync();

                if (latestAnnouncement == null)
                {
                    return NotFound("No announcement found.");
                }



                return Ok(
                    new
                    {
                        Title = latestAnnouncement.Title,
                        AudioUrl = latestAnnouncement.AudioUrl,
                    }

                    );
            }

        }
    }
}
