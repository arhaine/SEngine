using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Project.ScriptsV2.DescriptorSystem
{
	public abstract class AbstractDescriptor
	{
		private DescriptorAttribute _attribute;

		public DescriptorAttribute Attribute
		{
			get { return _attribute; }
			set { _attribute = value; }
		}

		public AbstractDescriptor(DescriptorAttribute attribute)
		{
			Attribute = attribute;
		}

		public abstract void Add(AbstractDescriptor desc);
		public abstract void Remove(AbstractDescriptor desc);
		public abstract void Display(int depth);
	}
}
