using Planru.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBlog.Core.Entities
{
    public class Blog : EntityBase
    {
        public string Url { get; set; }

        public virtual IList<Post> Posts { get; set; }

        public Blog()
        {
            Posts = new List<Post>();
        }
    }
}
