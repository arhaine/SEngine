using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Project.ScriptsV2.DescriptorSystem
{
	public abstract class DescriptorAttribute
	{
		public string Name { get; set; }
		public string Description { get; set; }

		protected DescriptorAttribute(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}
}
