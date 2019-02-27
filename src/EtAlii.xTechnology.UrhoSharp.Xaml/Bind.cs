using System;
using Portable.Xaml.Markup;

namespace EtAlii.xTechnology.UrhoSharp.Xaml
{
	public class Binding : MarkupExtension
	{
		public Binding(Type arg1, string arg2)
		{
			Foo = arg1;
			Bar = arg2;
		}

		[ConstructorArgument("arg1")]
		public Type Foo { get; set; }

		[ConstructorArgument("arg2")]
		public string Bar { get; set; }

		[ConstructorArgument("path")]
		public string Path { get; set; }

		[ConstructorArgument("converter")]
		public string Converter { get; set; }

		[ConstructorArgument("converterParameter")]
		public string ConverterParameter { get; set; }

		[ConstructorArgument("mode")]
		public string Mode { get; set; }


		public override object ProvideValue(IServiceProvider provider)
		{
			return "provided_value";
		}
	}
}
