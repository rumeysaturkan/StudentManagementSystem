﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
        public string Department { get; set; }

    }
}
