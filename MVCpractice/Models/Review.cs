using System.ComponentModel.DataAnnotations;

namespace MVCpractice.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required()]
        public string ReviewrEmail { get; set; }

    }
}