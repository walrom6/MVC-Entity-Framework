using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "AlbumId")]
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }

        public int GenreId { get; set; }
        public int ArtistId { get; set; }

        [Required (ErrorMessage = "An album title is required")]
        [StringLength (160)]
        public string Title { get; set; }

        [Required (ErrorMessage = "Price is required")]
        [Range (0.01, 100.00, ErrorMessage = "Price between 0.0 and 100.00")]
        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}