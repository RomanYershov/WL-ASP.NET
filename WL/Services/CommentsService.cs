using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WL.Services
{
    public class CommentsService : IService<Comments>
    {
        private ForumDbEntities context;

        public CommentsService()
        {
            context = new ForumDbEntities();
        }
        public void AddEntity(Comments model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comments model)
        {
            throw new NotImplementedException();
        }

        public List<Comments> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comments GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comments model)
        {
            throw new NotImplementedException();
        }

        public List<Comments> GetCommentsByDiscussionId(int discussionId)
        {
            var comments = context.CommentsSet.Where(c => c.Discussions.Id == discussionId).ToList();
            return comments;
        }
    }
}