using Friends.Domain.Entities;
using Friends.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Friends.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsAPIController : ControllerBase
    {
        private readonly IFriendsListService _friendsService;

        public FriendsAPIController(IFriendsListService friendsService)
        {
            _friendsService = friendsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_friendsService.GetAll());
        }

        [HttpGet]
        [Route("friend/{id}")]
        public IActionResult Get(int id) 
        {

            return Ok(_friendsService.Get(id));
              
        }

      
        [HttpPost]
        public IActionResult Create(Friend friend)
        {
            _friendsService.Create(friend);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            _friendsService.Delete(id);

            return NoContent();
        }

        [HttpPut]
        [Route("/friend")]
        public IActionResult Update(Friend friend) 
        {
            _friendsService.Update(friend);
            return NoContent();
        }
    }
}
