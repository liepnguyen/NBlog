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

        public List<Post> Posts { get; set; }
    }
}
