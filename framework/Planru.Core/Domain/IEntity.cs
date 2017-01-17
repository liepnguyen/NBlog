using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planru.Core.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
