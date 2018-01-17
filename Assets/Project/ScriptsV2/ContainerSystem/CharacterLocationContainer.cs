using System;
using System.Collections.Generic;
using NUnit.Framework;

public class CharacterLocationContainer : ContainerBase
{
	private CharacterLocationContainer _parentContainer;

	public CharacterLocationContainer ParentContainer
	{
		get { return _parentContainer; }
		set { _parentContainer = value; }
	}

	protected CharacterLocationContainer (CharacterLocationContainer parentContainer)
	{
		ParentContainer = parentContainer;
	}
	protected List<CharacterLocationContainer> Sublocations = new List<CharacterLocationContainer>();

	protected virtual void Initialize()
	{

	}

	public virtual List<CharacterLocationContainer> TryGetSublocations()
	{
		return Sublocations;
	}

	public override void TryInsertItem()
	{
		throw new NotImplementedException();
	}

	public override void TryExtractItem()
	{
		throw new NotImplementedException();
	}

    public override List<ContainerBase> TryGetSubcontainers()
    {
		throw new NotImplementedException();
    }

    public override ContainerBase TryGetSubcontainer()
    {
        throw new NotImplementedException();
    }

    public override void CheckAvailableSlots()
	{
		throw new NotImplementedException();
	}

    public override void Add(ContainerBase container)
    {
        throw new NotImplementedException();
    }

    public override void Remove(ContainerBase container)
    {
        throw new NotImplementedException();
    }
}
