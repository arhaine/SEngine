using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Project.ScriptsV2.DescriptorSystem
{
	public static class DescriptorAttributes
	{
		#region CharacterLevelDescriptors

		public class GenderAttribute : DescriptorAttribute
		{
			public GenderAttribute(string name, string description) : base(name, description)
			{
			}

			public static readonly GenderAttribute Female = new GenderAttribute("Female", "This represents that the character is Female");
			public static readonly GenderAttribute Male = new GenderAttribute("Male", "This represents that the character is Male");
		}
		public class HeightAttribute : DescriptorAttribute
		{
			public HeightAttribute(string name, string description) : base(name, description)
			{
			}

			public static readonly HeightAttribute Short = new HeightAttribute("Short", "This represents that the character is of Short Height");
			public static readonly HeightAttribute Medium = new HeightAttribute("Medium", "This represents that the character is of Medium Height");
			public static readonly HeightAttribute Tall = new HeightAttribute("Tall", "This represents that the character is of Tall Height");
			public static readonly HeightAttribute VeryTall = new HeightAttribute("VeryTall", "This represents that the character is of Very Tall Height");
		}

		#endregion

		public class ColorAttribute : DescriptorAttribute
		{
			public ColorAttribute(string name, string description) : base(name, description)
			{
			}

			public static readonly ColorAttribute Black = new ColorAttribute("Black", "This is color Black");
			public static readonly ColorAttribute Red = new ColorAttribute("Red", "This is color Red");
			public static readonly ColorAttribute White = new ColorAttribute("White", "This is color White");
            public static readonly ColorAttribute Ashen = new ColorAttribute("Ashen", "This is color Ashen");
			public static readonly ColorAttribute Blue = new ColorAttribute("Blue", "This is color Blue");
			public static readonly ColorAttribute Yellow = new ColorAttribute("Yellow", "This is color Yellow");
			public static readonly ColorAttribute Brown = new ColorAttribute("Brown", "This is color Brown");
			public static readonly ColorAttribute Cerulean = new ColorAttribute("Cerulean", "This is color Cerulean");
			public static readonly ColorAttribute DarkGreen = new ColorAttribute("Dark Green", "This is color Dark Green");
			public static readonly ColorAttribute Ebony = new ColorAttribute("Ebony", "This is color Ebony");
			public static readonly ColorAttribute Emerald = new ColorAttribute("Emerald", "This is color Emerald");
			public static readonly ColorAttribute Gray = new ColorAttribute("Gray", "This is color Gray");
			public static readonly ColorAttribute Green = new ColorAttribute("Green", "This is color Green");
			public static readonly ColorAttribute Indigo = new ColorAttribute("Indigo", "This is color Black");
			public static readonly ColorAttribute Olive = new ColorAttribute("Olive", "This is color Olive");
			public static readonly ColorAttribute Orange = new ColorAttribute("Orange", "This is color Orange");
			public static readonly ColorAttribute Pink = new ColorAttribute("Pink", "This is color Pink");
			public static readonly ColorAttribute Purple = new ColorAttribute("Purple", "This is color Black");
			public static readonly ColorAttribute Sable = new ColorAttribute("Sable", "This is color Sable");
			public static readonly ColorAttribute Sanguine = new ColorAttribute("Sanguine", "This is color Sanguine");
			public static readonly ColorAttribute Silver = new ColorAttribute("Silver", "This is color Silver");
			public static readonly ColorAttribute Tan = new ColorAttribute("Tan", "This is color Tan");
		}

		public class ColorAdjectiveAttribute : DescriptorAttribute
		{
			public ColorAdjectiveAttribute(string name, string description) : base(name, description)
			{
			}

			public static readonly ColorAdjectiveAttribute Pale = new ColorAdjectiveAttribute("Pale", "This is color adjective Pale");
			public static readonly ColorAdjectiveAttribute Dark = new ColorAdjectiveAttribute("Dark", "This is color adjective Dark");
			public static readonly ColorAdjectiveAttribute Light = new ColorAdjectiveAttribute("Light", "This is color adjective Light");
			public static readonly ColorAdjectiveAttribute Deep = new ColorAdjectiveAttribute("Deep", "This is color adjective Deep");
			public static readonly ColorAdjectiveAttribute Milky = new ColorAdjectiveAttribute("Milky", "This is color adjective Milky");
			public static readonly ColorAdjectiveAttribute Ashen = new ColorAdjectiveAttribute("Ashen", "This is color adjective Ashen");
			public static readonly ColorAdjectiveAttribute Striped = new ColorAdjectiveAttribute("Striped", "This is color adjective Striped");
			public static readonly ColorAdjectiveAttribute Shiny = new ColorAdjectiveAttribute("Shiny", "This is color adjective Shiny");
		}
	}
}
