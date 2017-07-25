using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentContainer : ContainerBase
{

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
        Debug.LogError("Component Containers can't have Subcontainers");
        return null;
    }

    public override ContainerBase TryGetSubcontainer()
    {
        Debug.LogError("Component Containers can't have Subcontainers");
        return null;
    }
    
    public override void Add(ContainerBase container)
    {
        Debug.LogError("Cannot Add to Component Containers");
    }

    public override void Remove(ContainerBase container)
    {
        Debug.LogError("Cannot Remove from Component Containers");
    }
}

#endregion
