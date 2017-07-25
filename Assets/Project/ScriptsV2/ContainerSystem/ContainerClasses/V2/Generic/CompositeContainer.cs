using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CompositeContainer : ContainerBase
{
    public List<ContainerBase> Subcontainers = new List<ContainerBase>();

    #region ItemHandling

    public override void TryInsertItem()
    {
        throw new NotImplementedException();
    }

    public override void TryExtractItem()
    {
        throw new NotImplementedException();
    }

    public override void CheckAvailableSlots()
    {
        throw new NotImplementedException();
    }

    #endregion

    #region ContainerHandling

    public override List<ContainerBase> TryGetSubcontainers()
    {
        throw new NotImplementedException();
    }

    public override ContainerBase TryGetSubcontainer()
    {
        throw new NotImplementedException();
    }
    
    public override void Add(ContainerBase container)
    {
        Subcontainers.Add(container);
    }

    public override void Remove(ContainerBase container)
    {
        Subcontainers.Add(container);
    }

    #endregion
}

