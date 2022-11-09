﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
        //Bir işte birden çok kişi çalışabilir.Bire Çok
    }
}
