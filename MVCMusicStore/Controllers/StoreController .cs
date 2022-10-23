using Microsoft.AspNetCore.Mvc;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var genres = new List<Genre>
                {
                    new Genre { Name = "Black Metal"},
                    new Genre { Name = "Hardcore punk"},
                    new Genre { Name = "Soundtrack"}
                };
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}
