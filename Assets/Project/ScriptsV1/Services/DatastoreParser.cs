using UnityEngine;
using System.Collections;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public static class DatastoreParser {

	public static T ParseYaml<T>(string path)
	{
		TextAsset equippableAsset = (TextAsset)Resources.Load(path);

		StringReader input = new StringReader(equippableAsset.text);

		Deserializer deserializer = new Deserializer(namingConvention: new PascalCaseNamingConvention());

		T parsedList = deserializer.Deserialize<T>(input);

		return parsedList;
	}
}
