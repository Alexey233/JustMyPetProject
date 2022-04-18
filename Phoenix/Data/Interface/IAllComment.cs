using Phoenix.Data.Models;

namespace Phoenix.Data.Interface
{
    public interface IAllComment
    {
        public IEnumerable<Comments> AllComments { get; }

        public Comments GetObjectComment(int commentId);
    }
}
