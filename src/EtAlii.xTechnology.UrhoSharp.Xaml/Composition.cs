using System;

namespace EtAlii.xTechnology.UrhoSharp.Xaml
{
	public class Composition
	{
		public Composition()
		{
			TestProp3 = "foobar";
		}

		public string TestProp1 { get; set; }
		// nested.
		public Composition TestProp2 { get; set; }

		public string TestProp3 { get; set; }

		public int TestProp4 { get; set; }
	}
}
