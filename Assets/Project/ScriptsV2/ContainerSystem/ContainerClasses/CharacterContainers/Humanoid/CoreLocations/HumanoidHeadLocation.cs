public sealed class HumanoidHeadLocation : CharacterLocationContainer
{
	public HumanoidHeadLocation(CharacterLocationContainer parentContainer) : base(parentContainer)
	{
		Initialize();
	}

	protected override void Initialize()
	{
		Sublocations.Add(new HairSublocation(this));
		Sublocations.Add(new BrowSublocation(this));
		Sublocations.Add(new BrowSublocation(this));
		Sublocations.Add(new EarSublocation(this));
		Sublocations.Add(new EarSublocation(this));
		Sublocations.Add(new EyesSublocation(this));
		Sublocations.Add(new LipsSublocation(this));
		Sublocations.Add(new NoseSublocation(this));

		base.Initialize();
	}
}
