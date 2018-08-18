using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WL.Services;

namespace WL.Models
{
    public class ForumViewModel
    {
        public List<Discussions> Discussions { get; private set; }
        public List<Categories> Categories { get; private set; }

        public static ForumViewModel GetModel()
        {
            var discussionsRep = new Repository<Discussions>(new ForumDbEntities());
            var categoriesRep = new Repository<Categories>(new ForumDbEntities());
            return new ForumViewModel
            {
                Discussions = discussionsRep.Get(),
                Categories = categoriesRep.Get()
            };
        }
    }
}