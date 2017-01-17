using Planru.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planru.NBlog.Core.Entities
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
