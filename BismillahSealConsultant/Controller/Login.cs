using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;

namespace BismillahSealConsultant.Controller
{
    [Route("login")]
    [ApiController]
    public class Login : ControllerBase
    {
        [HttpPost]

        public async Task<IActionResult> login( Employee e)
        {
            using(sealConsultantContext dbcontext = new sealConsultantContext())
            {
                var emp= dbcontext.Employees.FirstOrDefault(x => x.EmployeeCode == e.EmployeeCode && x.Password == e.Password);

                emp.JoiningDate = null;

                


                if (emp != null)
                {

                    Log log = new Log
                    {
                        Id = Guid.NewGuid(),
                        EmpId = emp.Id,
                        Item = "login",
                        DateTime = DateTime.Now,
                    };

                   dbcontext.Logs.Add(log);
                   await dbcontext.SaveChangesAsync();  

                    return Ok(emp);
                }
                else
                {
                    return NotFound();  
                }

            }


        }


    }
}
