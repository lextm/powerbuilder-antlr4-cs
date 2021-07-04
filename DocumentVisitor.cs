using System.Collections.Generic;
using Antlr4.Runtime.Misc;

namespace antlr4_powerbuilder_cs
{
    internal class DocumentVisitor : PowerBuilderParserBaseVisitor<Document>
    {
        public override Document VisitStart_rule([NotNull] PowerBuilderParser.Start_ruleContext context)
        {
            var result = new Document();
            var header = context.header_rule();
            if (header != null)
            {
                result.Header = new HeaderVisitor().VisitHeader_rule(header);
            }

            var body_rules = context.body_rule();
            foreach (var body_rule in body_rules)
            {
                var visitor = new BodyVisitor();
                result.Bodies.Add(visitor.VisitBody_rule(body_rule));
            }

            return result;
        }
    }

    internal class BodyVisitor : PowerBuilderParserBaseVisitor<Body>
    {
        public override Body VisitBody_rule([NotNull] PowerBuilderParser.Body_ruleContext context)
        {
            return base.VisitBody_rule(context);
        }
    }

    internal class HeaderVisitor : PowerBuilderParserBaseVisitor<Header>
    {
        public override Header VisitHeader_rule([NotNull] PowerBuilderParser.Header_ruleContext context)
        {
            return base.VisitHeader_rule(context);
        }
    }
}