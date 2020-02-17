﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    public class LaunchingSite
    {
        public LaunchingSite()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Orientation { get; set; }
        public string Description { get; set; }
    }
}