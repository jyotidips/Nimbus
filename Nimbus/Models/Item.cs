﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nimbus.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

    }
}