﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComicBookGalleryModel.Models
{
    public class Series
    {
        public Series()
        {
            ComicBooks = new List<ComicBook>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        public ICollection<ComicBook> ComicBooks { get; set; }
    }
}
