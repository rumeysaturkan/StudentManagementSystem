﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
    }
}
