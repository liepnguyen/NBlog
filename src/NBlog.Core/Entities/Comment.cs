using Planru.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBlog.Core.Entities
{
    public class Comment : EntityBase
    {
        public Guid PostId { get; set; }

        public Post Post { get; set; }
    }
}
