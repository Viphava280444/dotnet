using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System.Diagnostics;

namespace SimpleApi.Controllers;

public class HomeController : Controller
{
    private static readonly List<Message> _messages = new();
    private static long _counter = 0;

    public HomeController()
    {
        // Initialize with sample data if list is empty
        if (_messages.Count == 0)
        {
            _messages.Add(new Message { Id = ++_counter, Content = "Hello, World!" });
            _messages.Add(new Message { Id = ++_counter, Content = "Welcome to .NET Core!" });
        }
    }

    public IActionResult Index()
    {
        return View(_messages);
    }

    [Route("api/messages")]
    [HttpGet]
    public IActionResult GetMessages()
    {
        return Json(_messages);
    }
} 