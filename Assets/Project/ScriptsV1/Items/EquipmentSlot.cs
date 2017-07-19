using UnityEngine;
using System.Collections;
using Item;

public class EquipmentSlot
{
	//TODO: Set character in constructor
	public IEquipItems MyCharacter;

	public EquippableItem CurrentItem;

	public EquippableItemSlotEnums.EquipmentSlots SlotType;

	public EquipmentSlot(IEquipItems character, EquippableItemSlotEnums.EquipmentSlots slotType)
	{
		MyCharacter = character;
		SlotType = slotType;
	}

	public bool TryEquip(EquippableItem item, EquipmentSlot slot)
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

	private void ForceEquip(EquippableItem item, EquipmentSlot slot)
	{
		item.CurrentSlot = slot;
		slot.CurrentItem = item;

		slot.MyCharacter.StatsHaveChanged();
	}

	public bool CheckPrerequisites(EquippableItem item)
	{
		return item.Slot == SlotType;
	}
}
