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

        public virtual IList<Comment> Comments { get; set; }

        public User Author { get; set; }

        public Guid AuthorId { get; set; }

        public Category Category { get; set; }

        public Guid CategoryId { get; set; }

        public virtual IList<Tag> Tags { get; set; }

        public bool IsPublished { get; set; }

        public bool IsDeleted { get; set; }

        public Post()
        {
            Comments = new List<Comment>();
        }
    }
}
