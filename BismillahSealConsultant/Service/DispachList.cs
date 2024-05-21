using BismillahSealConsultant.DataModels;
using BismillahSealConsultant.Pages;

namespace BismillahSealConsultant.Service
{
    public class DispachList 
    {
        public List<Employee> ditchPatchlist { get; set ; } = new List<Employee>();
        
        public void add_employee(List<Employee> employees) 
        { 
             ditchPatchlist = employees.ToList();
        
        }  
    
    }

      
}
