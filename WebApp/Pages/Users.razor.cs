using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using WebApp;
using WebApp.Shared;
using Repository;
using AutoMapper;
using Domain;

namespace WebApp.Pages
{
    public partial class Users
    {
        [Inject] private UsersRepository UsersRepository { get; set; } = default!;
        [Inject] private IMapper Mapper { get; set; } = default!;
        public List<UserDTO> UsersList { get; set; } = default!;
        protected async override Task OnInitializedAsync()
        {
            UsersList = Mapper.Map<List<User>, List<UserDTO>>(await UsersRepository?.GetAll()!);
            UsersList.Add(new UserDTO()
            {
                Name = "sotiris"
            });
            await base.OnInitializedAsync();
        }

    }
}