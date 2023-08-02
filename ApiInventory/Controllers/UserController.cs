using ApiInventory.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ApiInventory.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUsers()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserbyId (long id)
        {
            throw new NotImplementedException();   
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser (long id)
        {
            throw new NotImplementedException();
        }

       [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateUser (CreateUserDTO user)
        {
            throw new NotImplementedException ();
        }

        [HttpPut] 
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> updateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }



    }
}
