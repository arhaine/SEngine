using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ContainerBase
{
	public abstract void TryInsertItem();

	public abstract void TryExtractItem();

	public abstract List<ContainerBase> GetSublocations();

	public abstract void CheckAvailableSlots();

}
