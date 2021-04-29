﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Demo_Day8_DB.Models
{
    [Keyless]
    public partial class OrderOption
    {
        [Column(TypeName = "decimal(18, 4)")]
        public decimal SalesTaxRate { get; set; }
        [Column(TypeName = "money")]
        public decimal FirstBookShipCharge { get; set; }
        [Column(TypeName = "money")]
        public decimal AdditionalBookShipCharge { get; set; }
    }
}
