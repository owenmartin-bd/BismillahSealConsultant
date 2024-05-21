using Microsoft.AspNetCore.Components;
using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;
using BlazorInputFile;
using Microsoft.EntityFrameworkCore;
using Blazored.Modal;
using BismillahSealConsultant.Componants;
using Blazored.Modal.Services;

namespace BismillahSealConsultant.Pages
{
    public partial class ProjectsManagement : ComponentBase
    {

        [CascadingParameter] IModalService Modal { get; set; } = default!;

        private async Task ShowModal()
        {
            var parameters = new ModalParameters().Add(nameof(AddGroupModals.projectID), projectId.ToString());

            var modal = Modal.Show<AddGroupModals>("Add New Group", parameters);


            var result = await modal.Result;

        }


        private async Task ShowModalTeam()
        {
            var parameters = new ModalParameters().Add(nameof(AddTeam.projectID), projectId.ToString());

                parameters.Add(nameof(AddTeam.GroupID), selectedGroup.Id.ToString());
                var modal = Modal.Show<AddTeam>("Add New Team", parameters);

                
                var result = await modal.Result;
           
            

           

        }

    }
}
