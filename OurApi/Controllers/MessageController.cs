using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace OurApi.Controllers
{
    public class MessageController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        } */
        private IHttpContextAccessor _accessor;
        public string Send(string clientId)
        {
            //string clientId
            //return "This is the Welcome action method... " + clientId + " " + _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return "ECHO " + clientId + " " + Request.HttpContext.Connection.RemoteIpAddress;
            

            //var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
        }
        /*
        public MessageController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        } */
    }
}