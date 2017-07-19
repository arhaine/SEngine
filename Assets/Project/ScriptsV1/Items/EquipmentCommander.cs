using System;
using UnityEngine;
using System.Collections;
using Item;
using UnityEditor;

public class EquipmentCommander : SingletonBehaviour<EquipmentCommander>
{
	//todo: Remove character class reference later
	public PlayerCharacter PlayerCharacter;

	private void Start()
	{
		TestEquip();
	}

	public void TestEquip()
	{
		PlayerCharacter = new PlayerCharacter("Lidia");

		var item = new EquippableItem
		{
			ItemID = 7,
			ItemName = "Black Stilettos",
			ItemDescriptor = "Nice black stilettos. You will definitely turn heads in those.",
			Slot = EquippableItemSlotEnums.EquipmentSlots.FeetSlot
		};

		PlayerCharacter.FeetSlot.TryEquip(item, PlayerCharacter.FeetSlot);

		//Equip(item);
	}

	public static bool TryEquip(EquippableItem item, EquipmentSlot slot)
	{
		if (item.CurrentSlot != null)
		{
			return false;
		}
		if (slot.CurrentItem != null)
		{
			return false;
		}
		if (!slot.CheckPrerequisites(item))
		{
			return false;
		}
		ForceEquip(item, slot);
		return true;
	}

	private static void ForceEquip(EquippableItem item, EquipmentSlot slot)
	{
		item.CurrentSlot = slot;
		slot.CurrentItem = item;

		slot.MyCharacter.StatsHaveChanged();
	}
	
}
