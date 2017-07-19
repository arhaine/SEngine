using Item;

public interface IEquipItems
{
	 EquipmentSlot HairSlot { get; set; }
	 EquipmentSlot EyesSlot { get; set; }
	 EquipmentSlot BrowPiercingSlot { get; set; }
	 EquipmentSlot EarPiercingSlot { get; set; }
	 EquipmentSlot NosePiercingSlot { get; set; }
	 EquipmentSlot LipsPeiercingSlot { get; set; }

	 EquipmentSlot UnderwearTopSlot { get; set; }
	 EquipmentSlot ClothingTopOverSlot { get; set; }
	 EquipmentSlot ClothingTopUnderSlot { get; set; }
	 EquipmentSlot JewelryNeckSlot { get; set; }

	 EquipmentSlot JewelryWristSlot { get; set; }
	 EquipmentSlot JeweleyFingerLeftSlot { get; set; }
	 EquipmentSlot JewelryFingerRightSlot { get; set; }
	 EquipmentSlot NailsSlot { get; set; }

	 EquipmentSlot ClothingBottomOverSlot { get; set; }
	 EquipmentSlot ClothingBottomUnderSlot { get; set; }
	 EquipmentSlot UnderwearBottomSlot { get; set; }
	 EquipmentSlot FeetSlot { get; set; }

	void StatsHaveChanged();
}
