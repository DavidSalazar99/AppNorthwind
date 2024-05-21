﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Northwind.Modelo
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }

}
