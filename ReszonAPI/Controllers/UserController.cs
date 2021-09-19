using Application.Interface;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ReszonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IApplicationUser _applicationUser;

        public UserController(IApplicationUser applicationUser)
        {
            _applicationUser = applicationUser;
        }

        [HttpGet]
        public ActionResult<string> GetOnlyActive()
        {
            return Ok(_applicationUser.GetOnlyActive());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_applicationUser.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                _applicationUser.Add(userDTO);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                _applicationUser.Update(userDTO);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult Remove([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                _applicationUser.Delete(userDTO);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
