using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Item;

public class Datastore : MonoBehaviour
{

	private const string EQUIPPABLE_ITEMS_YAML_PATH = "YAMLs/EquippableItems";
	private const string CONSUMABLE_ITEMS_YAML_PATH = "YAMLs/ConsumableItems";

	private class EquippableItemList
	{
		public List<EquippableItem> EquippableItems { get; set; }
	}

	private class ConsumableItemList
	{
		public List<ConsumableItem> ConsumableItems { get; set; }
	}

	public static List<EquippableItem> AllEquippableItems = new List<EquippableItem>();
	public static List<ConsumableItem> AllConsumableItems = new List<ConsumableItem>();

	public void Start()
	{
		AllEquippableItems = DatastoreParser.ParseYaml<EquippableItemList>(EQUIPPABLE_ITEMS_YAML_PATH).EquippableItems;
		AllConsumableItems = DatastoreParser.ParseYaml<ConsumableItemList>(CONSUMABLE_ITEMS_YAML_PATH).ConsumableItems;

		foreach (var consumableItem in AllConsumableItems)
		{
			Debug.Log(consumableItem.ItemName);
		}

	}
}
