using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCpractice.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}