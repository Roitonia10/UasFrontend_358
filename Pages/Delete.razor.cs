using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasBlazor358.Services;
using Microsoft.AspNetCore.Components;

namespace UasBlazor358.Pages
{
    public partial class Delete
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(id));
            NavigationManager.NavigateTo("/studentpage");
        }

    }
}