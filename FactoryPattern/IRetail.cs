﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IRetail
    {
        public double Price { get; set; }
        public string Color { get; set; }
        public void PrintDetails();
    }
}
