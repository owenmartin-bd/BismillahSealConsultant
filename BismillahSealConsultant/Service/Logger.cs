using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BismillahSealConsultant.Service
{


    public class Logger
    {

        //private readonly Blazored.LocalStorage.ILocalStorageService _localStorage;
        //public Logger(Blazored.LocalStorage.ILocalStorageService localStorage) 
        //{ 
        //   _localStorage= localStorage;
        //}

        public bool checkAccess(string pageUri, string rollid)
        {

            if (rollid == "5e11fe4a-3ed3-48b0-9e2b-6d7dec18d79a")
            {
                return true;
            }

            if (rollid != null)
            {
                Guid roolid = Guid.Parse(rollid);




                using (sealConsultantContext dbcontext = new sealConsultantContext())
                {
                    var page = dbcontext.Pages.FirstOrDefault(p => p.Uri == pageUri);

                    if (page != null)
                    {
                        Access? a = dbcontext.Accesses.FirstOrDefault(x => x.PageId == page.Id && x.RollId == roolid);

                        if (a != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }

                }

            }
            else
            {
                return false;
            }





        }




    }
}
