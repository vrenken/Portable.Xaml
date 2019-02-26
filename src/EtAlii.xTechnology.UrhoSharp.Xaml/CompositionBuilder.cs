using System;
using System.IO;
using System.Xml;
using Portable.Xaml;

namespace EtAlii.xTechnology.UrhoSharp.Xaml
{
	public class CompositionBuilder
	{

		public object Build(string filename)
		{
			string xml = File.ReadAllText(filename);
			using (var reader = new XamlXmlReader(XmlReader.Create(new StringReader(xml))))
			{
				var des = XamlServices.Load(reader);
				return des;
			}
		}
	}
}
