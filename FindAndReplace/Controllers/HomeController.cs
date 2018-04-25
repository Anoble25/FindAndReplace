using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FindAndReplace.Models;
using System;

namespace FindAndReplace.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      //List<Contact> allContacts = Contact.GetAll();
      return View();
    }

    [HttpGet("/findandreplace/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/findandreplace")]
    public ActionResult Create()
    {
      //Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-phoneNumber"], Request.Form["new-address"]);
      //List<Contact> allContacts = Contact.GetAll();
      Work newInputInfo= new Work (Request.Form["sentence"], Request.Form["chosenWord"], Request.Form["replacementWord"]);
      string output=Work.PerformStringReplacement(newInputInfo);
      Console.WriteLine(output);


      return View("Index", output);
    }

    // [HttpGet("/contacts/{id}")]
    // public ActionResult Details(int id)
    // {
    //     Contact contact = Contact.Find(id);
    //     return View(contact);
    // }

    // [HttpPost("/contacts/delete")]
    // public ActionResult DeleteAll()
    // {
    //     Contact.ClearAll();
    //     return View();
    // }

  }
}
