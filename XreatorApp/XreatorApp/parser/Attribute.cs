using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XreatorApp.parser
{
    class Attribute
    {
        public object Value { get; set; }
        public bool IsRequired { get; }
        public String Name { get; private set; }

        public Attribute(String AName, bool AIsRequired)
        {
            this.Name = AName;
            this.IsRequired = AIsRequired;
        }
    }

    class Attributes : List<Attribute>
    {

    }
}
