using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BismillahSealConsultant.Controller
{
    [Route("whr")]
    [ApiController]
    public class Wokinghourreq : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> get_request(ReceiveCorrectionReq r)
        {
            if (r == null)
            {
                return BadRequest("Request data is null.");
            }

            using (sealConsultantContext dbcontext = new sealConsultantContext())
            {
                WorkingHoursCorrectionRequest w = new WorkingHoursCorrectionRequest
                {
                    Id = Guid.NewGuid(),
                    Date = !string.IsNullOrEmpty(r.Date) ? DateOnly.Parse(r.Date) : null,
                    Inam = !string.IsNullOrEmpty(r.Inam) ? DateTime.Parse(r.Inam) : null,
                    Outpm = !string.IsNullOrEmpty(r.Outpm) ? DateTime.Parse(r.Outpm) : null,
                    EmployeeId = !string.IsNullOrEmpty(r.EmployeeId) ? Guid.Parse(r.EmployeeId) : null
                };



                await dbcontext.WorkingHoursCorrectionRequests.AddAsync(w);
                await dbcontext.SaveChangesAsync();
            }

            return Ok();
        }

    }
}

