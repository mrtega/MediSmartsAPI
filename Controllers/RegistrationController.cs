using Microsoft.AspNetCore.Mvc;
using MediSmartsAPI.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediSmartsAPI.Services;
using MediSmartsAPI.Request;
using MediSmartsAPI.Model;
using MediSmartsAPI.Response;

namespace MediSmartsAPI.Controllers
{
    public class RegistrationController : Controller 
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService transactionService)
        {
            _registrationService = transactionService;
        }

        [HttpGet(ApiRoutes.Registration.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _registrationService.GetUserAsync());
        }

        [HttpGet(ApiRoutes.Registration.Get)]
        public async Task<IActionResult> Get([FromRoute]Guid userId)
        {
            var user = await _registrationService.GetUserByIdAsync(userId);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPut(ApiRoutes.Registration.Update)]
        public async Task<IActionResult> Update([FromRoute]Guid userId, [FromBody] UpdateUserRequest request)
        {

            var user = await _registrationService.GetUserByIdAsync(userId);
            user.Date = request.Date;
            user.Email = request.Email;
            user.MobilePhone = request.MobilePhone;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.State = request.State;
            user.Country = request.Country;
            user.UserName = request.UserName;
            user.Age = request.Age;
            user.Password = request.Password;

            var updated = await _registrationService.UpdateUserAsync(user);
                if (updated)
                    return Ok(user);
                return NotFound();


        }

        [HttpPost(ApiRoutes.Registration.Create)]
        public async Task<IActionResult> Create([FromBody] CreateRegistrationRequest userRequest)
        {
            var user = new Registration
            {
                Date = userRequest.Date,
                Email = userRequest.Email,
                MobilePhone = userRequest.MobilePhone,
                UserName = userRequest.UserName,
                Country = userRequest.Country,
                State = userRequest.State,
                Password = userRequest.Password,
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                Age = userRequest.Age

            };

            await _registrationService.CreateUserAsync(user);

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUrl = baseUrl + "/" + ApiRoutes.Registration.Get.Replace("{transactionId}", user.Id.ToString());

            var response = new RegistrationResponse
            {
                Id = user.Id,
                State = user.State,
                Country = user.Country,
                MobilePhone = user.MobilePhone,
                Email = user.Email,
                Date = user.Date
            };
            return Created(locationUrl, response);
        }

        [HttpDelete(ApiRoutes.Registration.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid userId)
        {

            var deleted = await _registrationService.DeleteUserAsync(userId);

            if (deleted)
                return NoContent();
            return NotFound();
        }
    }
}
