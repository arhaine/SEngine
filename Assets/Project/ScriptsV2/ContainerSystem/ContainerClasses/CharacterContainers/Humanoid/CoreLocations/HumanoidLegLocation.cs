public sealed class HumanoidLegLocation : CharacterLocationContainer
{
	public HumanoidLegLocation(CharacterLocationContainer parentContainer) : base(parentContainer)
	{
		Initialize();
	}

	protected override void Initialize()
	{
		Sublocations.Add(new FootSublocation(this));
		Sublocations.Add(new LegOverSublocation(this));
		Sublocations.Add(new LegUnderSublocation(this));

		base.Initialize();
	}
}
