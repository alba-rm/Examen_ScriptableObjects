using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ScriptableItems : ScriptableObject
{
    public enum ItemType
    {
        Arma,
        Armadura
    }

    public ItemType itemType;
    public string itemName;
    public int itemPrice;
    public Sprite itemSprite;
}