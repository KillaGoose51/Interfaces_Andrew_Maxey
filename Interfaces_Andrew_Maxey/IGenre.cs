using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Andrew_Maxey
{
    interface IGenre
    {
        // automatic properties
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string  Title { get; set; }

        public string Describe();
    }
}
