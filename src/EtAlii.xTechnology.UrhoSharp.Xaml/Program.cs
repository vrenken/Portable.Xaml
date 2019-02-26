using System;

namespace EtAlii.xTechnology.UrhoSharp.Xaml
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var composition = new CompositionBuilder().Build("TestComposition.xaml");
		}
	}
}
