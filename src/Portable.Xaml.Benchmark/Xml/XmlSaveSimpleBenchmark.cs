using System;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BenchmarkDotNet.Attributes.Columns;

namespace Portable.Xaml.Benchmark.Xml
{
	public class XmlSaveSimpleBenchmark : SaveBenchmark
	{
		public override object Instance => new TestObject { StringProperty = "Hello" };
	}
}
