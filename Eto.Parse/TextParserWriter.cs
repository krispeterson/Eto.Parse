using System.IO;

namespace Eto.Parse
{
	public class TextParserWriter : ParserWriter<TextParserWriterArgs>
	{
		public string Indent { get; set; }

		public TextParserWriter(ParserDictionary writers = null)
			: base(writers)
		{
			Indent = "    ";
		}

		public string Write(Parser parser)
		{
			var writer = new StringWriter();
			Write(parser, writer);
			return writer.ToString();
		}

		public void Write(Parser parser, TextWriter writer)
		{
			var args = new TextParserWriterArgs(writer, Indent)
			{
				Writer = this
			};
			WriteParser(args, parser);
		}
	}
}
