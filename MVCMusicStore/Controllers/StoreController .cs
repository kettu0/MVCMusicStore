﻿using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
        + genre);

            return message;
        }

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}
