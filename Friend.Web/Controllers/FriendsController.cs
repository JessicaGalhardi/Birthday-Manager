using Friends.Domain.Interfaces;
using Friends.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Diagnostics;
using Friend.Web.Filters;
using Friends.Domain.Entities;
using Friend.Web.TagHelpers;
using Friend.Web.Views.Friends;
using Friends.Domain.ViewModels;

namespace Friend.Web.Controllers
{
    public class FriendsController : Controller
    {
        private readonly ILogger<FriendsController> _logger;
        private readonly IFriendsListService _friendsListService;
        private readonly IMessage _message;

        public FriendsController(ILogger<FriendsController> logger, IFriendsListService friendsListService, IMessage message)
        {
            _logger = logger;
            _friendsListService = friendsListService;
            _message = message;
        }

        private void SetSessions(List<int> selected)
        {
            var selectedItens = JsonConvert.SerializeObject(selected);
            HttpContext.Session.SetString("seleted itens", selectedItens);
        }

        private List<int> GetSessions()
        {
            var selectedInSessions = HttpContext.Session.GetString("Selected itens");

            if (string.IsNullOrEmpty(selectedInSessions))
            {
                return new List<int>();
            }

            return JsonConvert.DeserializeObject<List<int>>(selectedInSessions);
        }

        [HttpGet]

        public IActionResult Index()
        {
            var listFriends = _friendsListService.GetAll();

            var isSelected = GetSessions();

            foreach (var friend in listFriends)
            {
                friend.IsActive = isSelected.Contains(friend.Id);
            }

            return View(listFriends);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(List<int> selected)
        {

            SetSessions(selected);

            var listFriends = _friendsListService.GetSelected(selected);

            SetSessions(selected);


            return View(listFriends);
        }

        [HttpGet]
        public IActionResult Birthday()
        {
            var listFriends = _friendsListService.GetAll();

            var isSelected = GetSessions();

            foreach (var friend in listFriends)
            {
                friend.IsActive = isSelected.Contains(friend.Id);
            }


            return View(listFriends);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Birthday(List<int> selected)
        {

            SetSessions(selected);

            var listFriends = _friendsListService.GetSelected(selected);

            SetSessions(selected);


            return View(listFriends);
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Form(MessageModel messageViewModel)
        {

            //Setting a sucess message for the user

            ViewBag.messageOutput = new MessageOutput()
            {
                IsValid = true,
                Message = " Message sent was successfully! "
               
            };

            if (!ModelState.IsValid)
            {

                //Setting error message if a field is not filled in for the user
                ViewBag.messageOutput = new MessageOutput()
                {
                    IsValid = false,
                    Message = "An error has occurred"

                };               
            }

            return View(messageViewModel);
        }
        public IActionResult unknownError()
        {
            return View();
        }


        [ExceptionFilter]
        public IActionResult Error()
        {
            throw new Exception("");
        }
    }
}