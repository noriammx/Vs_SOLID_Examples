using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Test
{
    class Test
    {


        public void Save(String value)
        {
            if(value == "valor3")
            {
                value = "save";   
            }

        }

        public void Save2(String value)
        {
            if (value == "valor3")
            {
                value = "save";
            }

        }

        public void Save3(String value)
        {
            if (value == "valor3")
            {
                value = "save";
            }

        }
    }
}
