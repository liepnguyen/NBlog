using Planru.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBlog.Core.Entities
{
    public class Post : EntityBase
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public Guid BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
