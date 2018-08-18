﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WL.Services
{
    public class DiscussionRepository : IRepository<Discussions>
    {
        private ForumDbEntities db;
        private bool disposed = false;

        public DiscussionRepository()
        {
            db = new ForumDbEntities();
        }
        public void Commit()
        {
            db.SaveChanges();
        }

        public void Create(Discussions model)
        {
            db.DiscussionsSet.Add(model);
        }

        public void Delete(int id)
        {
            var discussion = db.DiscussionsSet.Find(id);
            if(discussion != null)
            db.DiscussionsSet.Remove(discussion);
        }

        public void Dispose()
        {
            Dispose();
        }

        public List<Discussions> Get()
        {
            return db.DiscussionsSet.ToList();
        }

        public void Update(Discussions model)
        {
            var discussion = db.DiscussionsSet.SingleOrDefault(d => d.Id == model.Id);
            discussion = model;
        }
    }
}