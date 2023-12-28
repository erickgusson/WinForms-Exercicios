using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExercicios
{
    class ClimaInfo
    {

        public class main
        {

            public double temp { get; set; }

            public double temp_min { get; set; }

            public double temp_max { get; set; }

            public double feels_like { get; set; }

        }

        public string name { get; set;}

        public class root
        {

            public main main { get; set; }

        }

    }
}
