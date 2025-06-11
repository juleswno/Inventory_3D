using UnityEngine;
using System.Collections.Generic;

public class Character
{
    public string Name { get; private set; }
    public string Title { get; private set; }
    public int Level { get; private set; }
    public int Exp { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int HP { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }

    // 인벤토리 아이템 리스트
    public List<Item> Inventory { get; private set; }

    public Character(string name, string title, int level, int exp, int attack, int defense, int hp, int critical, int gold)
    {
        Name = name;
        Title = title;
        Level = level;
        Exp = exp;
        Attack = attack;
        Defense = defense;
        HP = hp;
        Critical = critical;
        Gold = gold;

        // 테스트용 아이템 초기화
        Inventory = new List<Item>
        {
            new Item("빛나는 검", "오래된 검"),
            new Item("무명 원단", "가벼운 외투"),
            new Item("고양이 인형", "봉인된 추억")
        };
    }
}