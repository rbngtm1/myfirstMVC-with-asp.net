using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace firstMVC.Models
{
    public class Summer
    {
        public string SummerEvent { get; set; } = "Greek Festival";
        public string SummerLocation { get; set; }
        public int SummerYear { get; set; }
        public bool Active { get; set; }
        public string ImageURL { get; set; }
    }
}