
using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BismillahSealConsultant.Controller
{
    [Route("hour")]
    [ApiController]
    public class LatestWorkingHour : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> login(Employee e)
        {
            using (sealConsultantContext dbContext = new sealConsultantContext())
            {
                var hours = await dbContext.WorkerPaymentDetailsBydates
                                            .Where(x => x.EmployeeId == e.Id)
                                            .OrderByDescending(x => x.Date)
                                            .Take(5)
                                            .ToListAsync();

                if (hours != null && hours.Count > 0)
                {
                    var workingHoursList = hours.Select(hour =>
                    {
                        //var inTime = hour.InTime.HasValue ? hour.OutTime.Value : DateTime.MinValue;
                        //var outTime = hour.OutTime.HasValue ? hour,ou.Value : DateTime.MinValue;
                        //var outActual = 
                        
                        //var totalHours = hour.TotalHours.HasValue ? hour.TotalHours.Value : TimeSpan.Zero;
                        

                        // Format working hours as "hours:minutes"
                        //string formattedWorkingHours = totalHours.TotalHours >= 0 ? $"{(int)totalHours.TotalHours}:{totalHours.Minutes:D2}" : "N/A";

                        return new
                        {
                            date = hour.Date.HasValue ? hour.Date.Value.ToString("dd/MM/y") : "N/A",
                            intime =  $"{hour.InTime?.ToString("MM/dd/y h:mm tt")} \n ({hour.IntimeActual?.ToString("MM/dd/y h:mm tt")})",
                            outtime =  $"{hour.OutTime?.ToString("MM/dd/y h:mm tt")} \n ({hour.OutTimeActual?.ToString("MM/dd/y h:mm tt")})",
                            workingHours = hour.TotalHours
                        };
                    }).ToList();

                    return Ok(workingHoursList);
                }
                else
                {
                    return NotFound("No working hours found for the past 5 days.");
                }
            }
        }
    }
}
