using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasBlazor358.Models;
using UasBlazor358.Services;
using Microsoft.AspNetCore.Components;

namespace UasBlazor358.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
        public string id { get; set; }
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(int.Parse(id));
        }
    }
}