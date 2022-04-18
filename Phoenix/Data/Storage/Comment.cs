using Phoenix.Data.Interface;
using Phoenix.Data.Models;

namespace Phoenix.Data.Storage
{
    public class Comment : IAllComment
    {
        private readonly ApplicationDB _applicationDB;
        public Comment(ApplicationDB application)
        {
            this._applicationDB = application;
        }


        public IEnumerable<Comments> AllComments => _applicationDB.Comments;

        public Comments GetObjectComment(int commentId) => _applicationDB.Comments.FirstOrDefault(c => c.Id == commentId);
    }
}
