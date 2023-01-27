using Microsoft.AspNetCore.Mvc;
using Dws.Note_One.Api.Domain.Models;
using Dws.Note_One.Api.Domain.Services.IServices;
using Dws.Note_One.Api.Mapping;
using AutoMapper;
using Dws.Note_One.Api.Resources;
using Dws.Note_One.Api.Extensions;
namespace Dws.Note_One.Api.Controllers
{
    [Route("/api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IEnumerable<UserResource>> GetAllAsync()
        {
            var users = await _userService.ListAsync();
            var resources = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(users);
            return resources;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveUserResouce resouce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }
            var user = _mapper.Map<SaveUserResouce, User>(resouce);
            var result = await _userService.SaveAsync(user);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var userResource = _mapper.Map<User, UserResource>(result.User);
            return Ok(userResource);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveUserResouce resouce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }
            var user = _mapper.Map<SaveUserResouce, User>(resouce);
            var result = await _userService.UpdateAsync(id, user);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var userResource = _mapper.Map<User, UserResource>(result.User);
            return Ok(userResource);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _userService.DeleteAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var userResource = _mapper.Map<User, UserResource>(result.User);

            return Ok(userResource);
        }
    }
}