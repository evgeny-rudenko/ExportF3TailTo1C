using ePlus.Export1c.Client;
using System;
using System.Reflection;

namespace R14S1cExportRuUralNB
{
	public class Base : AbstractExport1cForm
	{
		public override string ReportName
		{
			get
			{
				string description = ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute))).Description;
				return description;
			}
		}

		public Base()
		{
		}
	}
}