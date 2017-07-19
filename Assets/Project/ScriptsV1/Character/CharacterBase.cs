using UnityEngine;

namespace Character
{
	public abstract class CharacterBase
	{
		public string Name;
		#region CharacterDescriptorEnumFields

		public CharacterEnums.Gender Gender;
		public CharacterEnums.Height Height;
		public CharacterEnums.SkinTone SkinTone;
		public CharacterEnums.BodyType BodyType;
		public CharacterEnums.ShoulderBroadness ShoulderBroadness;
		public CharacterEnums.ChestSize ChestSize;
		public CharacterEnums.Waist Waist;
		public CharacterEnums.Posterior Posterior;
		public CharacterEnums.Pelvis Pelvis;
		public CharacterEnums.LegLength LegLength;
		public CharacterEnums.LegWidth LegWidth;
		public CharacterEnums.HandsType HandsType;
		public CharacterEnums.FeetType FeetType;
		public CharacterEnums.Musculature Musculature;
		public CharacterEnums.Genitals Genitals;
		public CharacterEnums.GenitalStyling GenitalStyling;
		public CharacterEnums.HairStyle HairStyle;
		public CharacterEnums.HairColor HairColor;
		public CharacterEnums.EyeColor EyeColor;
		public CharacterEnums.EyeType EyeType;
		public CharacterEnums.IrisType IrisType;
		public CharacterEnums.LipsType LipsType;
		public CharacterEnums.LipsColor LipsColor;

		#endregion
	}
}

