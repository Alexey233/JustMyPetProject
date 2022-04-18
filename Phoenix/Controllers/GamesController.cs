using Microsoft.AspNetCore.Mvc;
using Phoenix.Data;
using Phoenix.Data.Interface;
using Phoenix.Data.Models;
using Phoenix.Data.Storage;
using Phoenix.ViewModel;

namespace Phoenix.Controllers
{
    public class GamesController : Controller
    {

        private readonly ApplicationDB _applicationDB;
        private readonly IAllUrlForGames _allUrlForGames;
        public GamesController(ApplicationDB applicationDB, IAllUrlForGames allUrlForGames)
        {
            this._applicationDB = applicationDB;
            this._allUrlForGames = allUrlForGames;
        }


        public IActionResult UsefulUrl()
        {
            var Url = new UrlForViewModel { AllUsefulUrl = _allUrlForGames.AllUsefulUrl };

            return View(Url);
        }

       

        public IActionResult InfoAboutUrl(int id)
        {
            var Info = new InfoAboutUrlViewModel
            {
                UsefulUrl = _applicationDB.UsefulUrl.FirstOrDefault(p => p.Id == id)
            };

            return View(Info);
        }


        public IActionResult NewUrl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUrl(UsefulUrl usefulUrl)
        {
            _applicationDB.UsefulUrl.Add(usefulUrl);
            _applicationDB.SaveChanges();
            return Redirect("/Games/UsefulUrl");
        }


        public IActionResult DeleteUrl(int id)
        {
            var forRemove = _applicationDB.UsefulUrl.FirstOrDefault(p => p.Id == id);
            if (forRemove != null)
            _applicationDB.UsefulUrl.Remove(forRemove);


            _applicationDB.SaveChanges();
            return Redirect("/Games/UsefulUrl");
        }
    }
}
