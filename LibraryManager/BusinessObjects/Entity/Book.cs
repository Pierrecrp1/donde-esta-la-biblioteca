﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Pages { get; set; }
        public BookTypes Type { get; set; }
        public int Rate { get; set; }
        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }
    }

}
