using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Project.ScriptsV2.DescriptorSystem
{
	class CompositeDescriptor : AbstractDescriptor
	{
		public List<AbstractDescriptor> ChildDescriptors = new List<AbstractDescriptor>();

		public CompositeDescriptor(DescriptorAttribute attribute) : base(attribute)
		{
		}

		public override void Add(AbstractDescriptor desc)
		{
			ChildDescriptors.Add(desc);
		}

		public override void Remove(AbstractDescriptor desc)
		{
			ChildDescriptors.Remove(desc);
		}

		public override void Display(int depth)
		{
			throw new NotImplementedException();
		}
	}
}
