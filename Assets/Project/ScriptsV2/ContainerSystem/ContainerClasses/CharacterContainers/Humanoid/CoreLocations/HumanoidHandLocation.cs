
public sealed class HumanoidHandLocation : CharacterLocationContainer
{
	public HumanoidHandLocation(CharacterLocationContainer parentContainer) : base(parentContainer)
	{
		Initialize();
	}

	protected override void Initialize()
	{
		for (int i = 0; i < 5; i++)
		{
			Sublocations.Add(new FingerSublocation(this));
		}
		Sublocations.Add(new WristSublocation(this));
		Sublocations.Add(new NailSublocation(this));

		base.Initialize();
	}

}
