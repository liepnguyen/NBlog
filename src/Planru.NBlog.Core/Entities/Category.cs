using Planru.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planru.NBlog.Core.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        public virtual IList<Category> Childs { get; set; }

        public Category Parent { get; set; }

        public Guid? ParentId { get; set; }

        public Category()
        {
            Childs = new List<Category>();
        }
    }
}
