using UnityEngine;
using System.Collections;
using Character;
using Item;

public class PlayerCharacter : CharacterBase, IEquipItems
{

	public PlayerCharacter(string name)
	{
		Name = name;
		InitializeSlots();
	}

	private void InitializeSlots()
	{
		HairSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.HairSlot);
		EyesSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.EyesSlot);
		BrowPiercingSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.BrowPiercingSlot);
		EarPiercingSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.EarPiercingSlot);
		NosePiercingSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.NosePiercingSlot);
		LipsPeiercingSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.LipsPeiercingSlot);
		UnderwearTopSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.UnderwearTopSlot);
		ClothingTopOverSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.ClothingTopOverSlot);
		ClothingTopUnderSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.ClothingTopUnderSlot);
		JewelryNeckSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.JewelryNeckSlot);
		JewelryWristSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.JewelryWristSlot);
		JeweleyFingerLeftSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.JeweleyFingerLeftSlot);
		JewelryFingerRightSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.JewelryFingerRightSlot);
		NailsSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.NailsSlot);
		ClothingBottomOverSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.ClothingBottomOverSlot);
		ClothingBottomUnderSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.ClothingBottomUnderSlot);
		UnderwearBottomSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.UnderwearBottomSlot);
		FeetSlot = new EquipmentSlot(this, EquippableItemSlotEnums.EquipmentSlots.FeetSlot);
	}

	#region EquipmentSlots

	private EquipmentSlot _hairSlot;
	private EquipmentSlot _eyesSlot;
	private EquipmentSlot _browPiercingSlot;
	private EquipmentSlot _earPiercingSlot;
	private EquipmentSlot _nosePiercingSlot;
	private EquipmentSlot _lipsPeiercingSlot;
	private EquipmentSlot _underwearTopSlot;
	private EquipmentSlot _clothingTopOverSlot;
	private EquipmentSlot _clothingTopUnderSlot;
	private EquipmentSlot _jewelryNeckSlot;
	private EquipmentSlot _jewelryWristSlot;
	private EquipmentSlot _jeweleyFingerLeftSlot;
	private EquipmentSlot _jewelryFingerRightSlot;
	private EquipmentSlot _nailsSlot;
	private EquipmentSlot _clothingBottomOverSlot;
	private EquipmentSlot _clothingBottomUnderSlot;
	private EquipmentSlot _underwearBottomSlot;
	private EquipmentSlot _feetSlot;

	private void LogEquip(EquipmentSlot itemEquippable)
	{
		Debug.Log("Something was equipped into slot: ");
	}

	public EquipmentSlot HairSlot
	{
		get { return _hairSlot; }
		set { _hairSlot = value; }
	}

	public EquipmentSlot EyesSlot
	{
		get { return _eyesSlot; }
		set { _eyesSlot = value; }
	}

	public EquipmentSlot BrowPiercingSlot
	{
		get { return _browPiercingSlot; }
		set { _browPiercingSlot = value; }
	}

	public EquipmentSlot EarPiercingSlot
	{
		get { return _earPiercingSlot; }
		set { _earPiercingSlot = value; }
	}

	public EquipmentSlot NosePiercingSlot
	{
		get { return _nosePiercingSlot; }
		set { _nosePiercingSlot = value; }
	}

	public EquipmentSlot LipsPeiercingSlot
	{
		get { return _lipsPeiercingSlot; }
		set { _lipsPeiercingSlot = value; }
	}

	public EquipmentSlot UnderwearTopSlot
	{
		get { return _underwearTopSlot; }
		set { _underwearTopSlot = value; }
	}

	public EquipmentSlot ClothingTopOverSlot
	{
		get { return _clothingTopOverSlot; }
		set { _clothingTopOverSlot = value; }
	}

	public EquipmentSlot ClothingTopUnderSlot
	{
		get { return _clothingTopUnderSlot; }
		set { _clothingTopUnderSlot = value; }
	}

	public EquipmentSlot JewelryNeckSlot
	{
		get { return _jewelryNeckSlot; }
		set { _jewelryNeckSlot = value; }
	}

	public EquipmentSlot JewelryWristSlot
	{
		get { return _jewelryWristSlot; }
		set { _jewelryWristSlot = value; }
	}

	public EquipmentSlot JeweleyFingerLeftSlot
	{
		get { return _jeweleyFingerLeftSlot; }
		set { _jeweleyFingerLeftSlot = value; }
	}

	public EquipmentSlot JewelryFingerRightSlot
	{
		get { return _jewelryFingerRightSlot; }
		set { _jewelryFingerRightSlot = value; }
	}

	public EquipmentSlot NailsSlot
	{
		get { return _nailsSlot; }
		set { _nailsSlot = value; }
	}

	public EquipmentSlot ClothingBottomOverSlot
	{
		get { return _clothingBottomOverSlot; }
		set { _clothingBottomOverSlot = value; }
	}

	public EquipmentSlot ClothingBottomUnderSlot
	{
		get { return _clothingBottomUnderSlot; }
		set { _clothingBottomUnderSlot = value; }
	}

	public EquipmentSlot UnderwearBottomSlot
	{
		get { return _underwearBottomSlot; }
		set { _underwearBottomSlot = value; }
	}

	public EquipmentSlot FeetSlot
	{
		get { return _feetSlot; }
		set { _feetSlot = value; }
	}

	public void StatsHaveChanged()
	{
		Debug.Log("Stats have changed!");
	}

	#endregion


}
