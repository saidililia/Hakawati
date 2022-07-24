using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakawati.Models
{
    internal class Story
    {
        public string Name { get; set; }
        public String MainImage { get; set; }

        public Story(string name, String main) {
            Name = name;
            MainImage = main;
        }


    }
}
