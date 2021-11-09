using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetAllUsers()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, StaticDb.Users);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error has occured");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetUser(int id)
        {
            try
            {
                if (id < 0)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "You have entered negative number");
                }
                else if (id >= StaticDb.Users.Count)
                {
                    return StatusCode(StatusCodes.Status404NotFound, $"The id {id} you have entered is invalid");
                }
                return StatusCode(StatusCodes.Status200OK, StaticDb.Users[id]);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error has occured");
            }

        }

        [HttpPost]
        public IActionResult AddUser()
        {
            try
            {
                using(StreamReader streamReader = new StreamReader(Request.Body))
                {
                    string user = streamReader.ReadToEnd();
                    StaticDb.Users.Add(user);
                    return StatusCode(StatusCodes.Status201Created, "You have added new user");
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error has occured");
            }
        }

        [HttpDelete]
        public IActionResult DeleteUser()
        {
            try
            {
                using(StreamReader streamReader = new StreamReader(Request.Body))
                {
                    string requestBody = streamReader.ReadToEnd();
                    int id = int.Parse(requestBody);
                    if (id < 0)
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, "You have entered negative number");
                    }
                    else if (id >= StaticDb.Users.Count)
                    {
                        return StatusCode(StatusCodes.Status404NotFound, $"The id {id} you have entered is invalid");
                    }
                    StaticDb.Users.RemoveAt(id);
                    return StatusCode(StatusCodes.Status204NoContent, $"You have deleted the User with id {id}");
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error has occured");
            }
        }
    }
}
