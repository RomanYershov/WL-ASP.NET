using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WL.Services
{
    public class DiscussionService : IService<Discussions>
    {
        private ForumDbEntities context;

        public DiscussionService()
        {
            context = new ForumDbEntities();
        }
        public void AddEntity(Discussions model)
        {
            context.DiscussionsSet.Add(model);
            context.SaveChanges();
        }

        public void Delete(Discussions model)
        {
            context.DiscussionsSet.Remove(model);
            context.SaveChanges();
        }


        public List<Discussions> GetAll()
        {
            return context.DiscussionsSet.ToList();
        }

        public Discussions GetEntityById(int id)
        {
            return context.DiscussionsSet.Find(id);
        }

        public void Update(Discussions model)
        {
            var discussion = context.DiscussionsSet.Find(model.Id);
            discussion.Name = model.Name;
            discussion.Description = model.Description;
            discussion.DateTime = discussion.DateTime;
            discussion.Categories = model.Categories;
            context.SaveChanges();
        }
    }
}