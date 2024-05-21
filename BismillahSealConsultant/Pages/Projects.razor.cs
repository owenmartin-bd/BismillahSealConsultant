using BismillahSealConsultant.Componants;
using BismillahSealConsultant.DataModels;
using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;

namespace BismillahSealConsultant.Pages
{
    public partial class Projects : ComponentBase
    {

        [CascadingParameter] IModalService Modal { get; set; } = default!;
        private async Task ShowModal()
        {
            var parameters = new ModalParameters().Add(nameof(AddGroupModals.projectID), "");

            var modal = Modal.Show<AddGroupModals>("Add New Group", parameters);
            var result = await modal.Result;

        }

    }
}
