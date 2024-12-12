﻿using Microsoft.AspNetCore.Mvc;
using GymTrackersAPI.Entities;
using Gym_TrackerAPI.Entities;
using Gym_TrackerAPI.Repositiories;
namespace Gym_TrackerAPI.Controllers
{
   
    
        [Route("api/[controller]")]
        [ApiController]
        public class CustomerEmailController : ControllerBase
        {
            private readonly IEmailInput _emailInput;

            public CustomerEmailController(IEmailInput emailInput)
            {
                _emailInput = emailInput;
            }

            [HttpGet("Email")]
            public async Task<ActionResult<List<CustomerEmail>>> Customer_Email_Input(string email)
            {
                var customerEmails = await _emailInput.Customer_Email_Input(email);

                if (customerEmails == null)
                {
                    return NotFound();
                }
                return Ok(customerEmails);
            }
        }
    }