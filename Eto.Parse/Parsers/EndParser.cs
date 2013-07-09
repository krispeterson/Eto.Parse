using System;
using Eto.Parse;
using System.Collections.Generic;

namespace Eto.Parse.Parsers
{
	public class EndParser : Parser
	{
		protected EndParser(EndParser other, ParserCloneArgs chain)
			: base(other, chain)
		{
		}

		public EndParser()
		{
		}

		protected override ParseMatch InnerParse(ParseArgs args)
		{
			if (args.Scanner.IsEof)
				return args.EmptyMatch;
			else
				return args.NoMatch;
		}

		public override IEnumerable<NamedParser> Find(string parserId)
		{
			yield break;
		}

		public override Parser Clone(ParserCloneArgs chain)
		{
			return new EndParser(this, chain);
		}
	}
}
