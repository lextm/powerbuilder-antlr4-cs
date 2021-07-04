using System;
using Antlr4.Runtime;

namespace antlr4_powerbuilder_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = "/*Hello World in Powerbuilder-Simple*/" + Environment.NewLine +
                          "MessageBox(\"Hi from Powerbuilder\", \"Hello World!\")";
            var lexer = new PowerBuilderLexer(new AntlrInputStream(content));
            var tokens = new CommonTokenStream(lexer);
            var parser = new PowerBuilderParser(tokens);
            DocumentVisitor visitor = new DocumentVisitor();
            var document = visitor.Visit(parser.start_rule());
            if (document.Header != null)
            {

            }
        }
    }
}
