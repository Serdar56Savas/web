﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShopping.Models.Sınıflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string urunad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2500)]
        public string urunbilgi { get; set; }
    }
}