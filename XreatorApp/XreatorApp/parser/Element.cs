using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XreatorApp.parser
{
    class Element
    {
        private Attributes AllAttributes;

        public String Name { get; private set; }
        public Elements ChildElements { get; set; }
        public Attributes OptionalAttributes { get; }
        public Attributes RequiredAttributes { get; }

        public Element(String AName)
        {
            this.Name = AName;
            this.AllAttributes = new Attributes();
            this.ChildElements = new Elements();
        }

        public void AddAttribute(Attribute AAttribute)
        {
            this.AllAttributes.Add(AAttribute);
        }
    }

    class Elements : List<Element>
    {

    }
}
