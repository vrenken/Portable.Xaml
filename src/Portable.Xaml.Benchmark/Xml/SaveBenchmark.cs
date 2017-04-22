using System;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BenchmarkDotNet.Attributes.Columns;

namespace Portable.Xaml.Benchmark.Xml
{
	public abstract class SaveBenchmark : IXamlBenchmark
	{
		public abstract object Instance { get; }

		Portable.Xaml.XamlSchemaContext pxc;
		[Benchmark(Baseline = true)]
		public void PortableXaml()
		{
			pxc = pxc ?? (pxc = new XamlSchemaContext());
			using (var writer = new StringWriter())
				XamlServices.Save(new XamlXmlWriter(writer, pxc), Instance);
		}

		System.Xaml.XamlSchemaContext sxc;
		[Benchmark]
		public void SystemXaml()
		{
			sxc = sxc ?? (sxc = new System.Xaml.XamlSchemaContext());
			using (var writer = new StringWriter())
				System.Xaml.XamlServices.Save(new System.Xaml.XamlXmlWriter(writer, sxc), Instance);
		}

		[Benchmark]
		public void PortableXamlNoCache()
		{
			using (var writer = new StringWriter())
				Portable.Xaml.XamlServices.Save(writer, Instance);
		}

		[Benchmark]
		public void SystemXamlNoCache()
		{
			using (var writer = new StringWriter())
				System.Xaml.XamlServices.Save(writer, Instance);
		}
	}
}
