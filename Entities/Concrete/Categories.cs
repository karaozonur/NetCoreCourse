﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Categories:IEntity
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
        //public string Description { get; set; }
        //public string Picture { get; set; }
    }
}
