using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BismillahSealConsultant.Controller
{
    public class CreateAdvanceDto
    {
        public DateOnly? RequestedDate { get; set; }
        public Guid? EmployeeId { get; set; }
        public double? Amount { get; set; }
    }
    public class UpdateDetchpatchedAmountDto
    {
        public double? DetchpatchedAmount { get; set; }
        public DateOnly? DetchpatchedDate { get; set; }
    }



    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateAdvance([FromBody] CreateAdvanceDto advanceDto)
        {
            if (advanceDto == null || !advanceDto.EmployeeId.HasValue || !advanceDto.Amount.HasValue)
            {
                return BadRequest("Invalid advance data");
            }

            var advance = new Advance
            {
                Id = Guid.NewGuid(),
                RequestedDate = advanceDto.RequestedDate,
                EmployeeId = advanceDto.EmployeeId,
                RequestAmount = advanceDto.Amount,
                Requested = true // Assuming that a new advance request is always in the requested state
            };

            using (var context = new sealConsultantContext())
            {
                context.Advances.Add(advance);
                await context.SaveChangesAsync();
            }

            return CreatedAtAction(nameof(GetEmployeeLatestAdvances), new { id = advance.Id }, advance);
        }

        // Updated GET method to retrieve the last five advance requests for a specific employee
        [HttpGet("latest/{employeeId}")]
        public async Task<IActionResult> GetEmployeeLatestAdvances(Guid employeeId)
        {
            using (var context = new sealConsultantContext())
            {
                var latestAdvances = await context.Advances.Where(a => a.EmployeeId == employeeId).OrderByDescending(a => a.RequestedDate).Take(5).ToListAsync();

                if (!latestAdvances.Any())
                {
                    return NotFound($"No advance requests found for employee ID {employeeId}.");
                }

                return Ok(latestAdvances);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployeeLatestAdvances(Guid employeeId, decimal advance)
        {
            using (var context = new sealConsultantContext())
            {
                var latestAdvance = await context.Advances.Where(a => a.EmployeeId == employeeId).FirstOrDefaultAsync();
            }

            return Ok();
        }
    }
}
