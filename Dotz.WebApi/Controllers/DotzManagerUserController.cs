using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotz.Application;
using Dotz.Application.User;

namespace Dotz.WebApi.Controllers
{

    public class DotzManagerUserController : Controller
    {
        private readonly UserServiceApplication userServiceApplication;
        protected DotzManagerUserController()
        {
            userServiceApplication = new UserServiceApplication();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public UserDto Get(long id)
        {
            return new UserDto();
        }

       //Criar Usuario
        [HttpPost]
        public async Task CreateUser(UserDto dto)
        {
           await  userServiceApplication.Create(dto);
        }

        [HttpPost]
        public async Task SendPunctuation(UserDotzDto dto)
        {
            await userServiceApplication.SendPunctuation(dto);
        }
    }
}
