﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseBootcampMVC.Models
{
    public class Credentials
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
