using System.Collections.Generic;

namespace antlr4_powerbuilder_cs
{
    internal class Document
    {
        public Header Header { get; set; }
        public List<Body> Bodies { get; } = new List<Body>();

    }
}