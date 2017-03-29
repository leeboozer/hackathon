using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ImageStore
    {
        public ImageStore()
        {
            Badge = new HashSet<Badge>();
            CandidateImageStore = new HashSet<Candidate>();
            CandidateProfileImageStore = new HashSet<Candidate>();
            NewsArticle = new HashSet<NewsArticle>();
        }

        public long ImageId { get; set; }
        public int ImageTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public byte[] ImageStoreItem { get; set; }

        public virtual ICollection<Badge> Badge { get; set; }
        public virtual ICollection<Candidate> CandidateImageStore { get; set; }
        public virtual ICollection<Candidate> CandidateProfileImageStore { get; set; }
        public virtual ICollection<NewsArticle> NewsArticle { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
    }
}
