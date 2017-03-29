using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class NewsArticle
    {
        public long NewsId { get; set; }
        public string Name { get; set; }
        public string ArticleContent { get; set; }
        public long? ImageStoreId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Author { get; set; }

        public virtual ImageStore ImageStore { get; set; }
    }
}
