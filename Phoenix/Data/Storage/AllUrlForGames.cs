using Phoenix.Data.Interface;
using Phoenix.Data.Models;

namespace Phoenix.Data.Storage
{
    public class AllUrlForGames : IAllUrlForGames
    {
        private readonly ApplicationDB _applicationDB;
        public AllUrlForGames(ApplicationDB application)
        {
            this._applicationDB = application;
        }
        public IEnumerable<UsefulUrl> AllUsefulUrl => _applicationDB.UsefulUrl;


        public UsefulUrl GetObjectUsefulUrl(int urlId) => _applicationDB.UsefulUrl.FirstOrDefault(p => p.Id == urlId);

    }
}
