using Phoenix.Data.Models;

namespace Phoenix.Data.Interface
{
    public interface IAllUrlForGames
    {
        public IEnumerable<UsefulUrl> AllUsefulUrl { get; }

        public UsefulUrl GetObjectUsefulUrl(int urlId);
    }
}
