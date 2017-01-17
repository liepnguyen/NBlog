using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planru.Core.Domain
{
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
