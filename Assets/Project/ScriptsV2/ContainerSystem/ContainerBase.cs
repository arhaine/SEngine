using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ContainerBase
{
	public abstract void TryInsertItem();

	public abstract void TryExtractItem();

    public abstract List<ContainerBase> TryGetSubcontainers();

    public abstract ContainerBase TryGetSubcontainer();

    public abstract void CheckAvailableSlots();

    public abstract void Add(ContainerBase container);

    public abstract void Remove(ContainerBase container);

}
