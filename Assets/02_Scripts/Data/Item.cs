using UnityEngine;

public class Item
{
    // 아이템 이름
    public string Name { get; private set; }

    // 아이템 설명
    public string Description { get; private set; }

    // 장착 여부
    public bool IsEquipped { get; private set; }

    // 생성자
    public Item(string name, string description, bool isEquipped = false)
    {
        Name = name;
        Description = description;
        IsEquipped = isEquipped;
    }

    // 장착 처리
    public void Equip() => IsEquipped = true;

    // 장착 해제 처리
    public void UnEquip() => IsEquipped = false;
}