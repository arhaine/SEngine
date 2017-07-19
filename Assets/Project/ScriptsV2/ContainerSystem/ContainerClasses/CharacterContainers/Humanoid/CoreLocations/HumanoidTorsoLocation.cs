public sealed class HumanoidTorsoLocation : CharacterLocationContainer
{
	public HumanoidTorsoLocation(CharacterLocationContainer parentContainer) : base(parentContainer)
	{
		Initialize();
	}

	protected override void Initialize()
	{
		Sublocations.Add(new HumanoidHeadLocation(this));
		Sublocations.Add(new HumanoidHandLocation(this));
		Sublocations.Add(new HumanoidHandLocation(this));
		Sublocations.Add(new HumanoidLegLocation(this));
		Sublocations.Add(new HumanoidLegLocation(this));

		Sublocations.Add(new NeckSublocation(this));
		Sublocations.Add(new TopOverSublocation(this));
		Sublocations.Add(new TopUnderSublocation(this));
		Sublocations.Add(new UnderwearBottomSublocation(this));
		Sublocations.Add(new UnderwearTopSublocation(this));

		base.Initialize();
	}
}
