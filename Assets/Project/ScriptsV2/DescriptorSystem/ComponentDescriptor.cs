using System;
using UnityEngine;
using UnityEngine.Diagnostics;
namespace Assets.Project.ScriptsV2.DescriptorSystem
{
	public class ComponentDescriptor : AbstractDescriptor
	{
		public ComponentDescriptor(DescriptorAttribute attribute) : base(attribute)
		{
		}

		public override void Add(AbstractDescriptor desc)
		{
			Debug.LogError("Cannot Add to ComponentDescriptor!");
		}

		public override void Remove(AbstractDescriptor desc)
		{
			Debug.LogError("Cannot Remove from ComponentDescriptor!");
		}

		public override void Display(int depth)
		{
			throw new NotImplementedException();
		}
	}
}
