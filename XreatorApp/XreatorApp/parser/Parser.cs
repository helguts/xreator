using System;
using System.IO;
using System.Xml.Schema;

namespace XreatorApp.parser
{
    class Parser
    {
        private XmlSchemaSet SchemaSet;


        public Parser()
        {
        }

        public Boolean ParseFile(String Filename)
        {
            FileStream fs = new FileStream(Filename, FileMode.Open);
            var schema = XmlSchema.Read(fs, null);

            SchemaSet = new XmlSchemaSet();
            SchemaSet.Add(schema);
            SchemaSet.Compile();
            return true;
        }
    }
}
