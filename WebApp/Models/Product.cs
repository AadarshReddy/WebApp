using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public double? Pprice { get; set; }
        public int? Pcat { get; set; }

        public virtual Category? PcatNavigation { get; set; }
    }
}
