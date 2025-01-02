﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Movie
    {
        
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        public DateTime DateOfRelease { get; set; }

    }
}