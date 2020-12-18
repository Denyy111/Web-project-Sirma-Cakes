namespace SirmaCakes.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SirmaCakes.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public int CakeId { get; set; }

        public virtual Cake Cake { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}
