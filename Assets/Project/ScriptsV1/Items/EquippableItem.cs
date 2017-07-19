namespace Item
{
	public class EquippableItem : ItemBase, IEquippable
	{
		public EquippableItemSlotEnums.EquipmentSlots Slot { get; set; }

		public EquipmentSlot CurrentSlot;

	}
}