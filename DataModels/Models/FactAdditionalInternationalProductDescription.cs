using System;
using System.Collections.Generic;

namespace DataModels.Models
{
    public partial class FactAdditionalInternationalProductDescription
    {
        public int ProductKey { get; set; }
        public string CultureName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
    }
}
