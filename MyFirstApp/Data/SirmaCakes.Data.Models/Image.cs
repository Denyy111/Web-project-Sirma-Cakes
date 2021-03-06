﻿namespace SirmaCakes.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SirmaCakes.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int CakeId { get; set; }

        public virtual Cake Cake { get; set; }

        // the contents of the image is in the file system
        public string Extension { get; set; }
 
        public string RemoteImageUrl { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
