﻿using System;
using System.Collections.Generic;

namespace DataModels.Models
{
    public partial class VAssocSeqLineItem
    {
        public string OrderNumber { get; set; } = null!;
        public byte LineNumber { get; set; }
        public string? Model { get; set; }
    }
}
