using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItems[] armas;

    public Text[] armasNames;
    
    public Text[] armasPrices;

    public Image[] armasSprites;


    public ScriptableItems[] armadura;

    public Text[] armaduraNames;
    
    public Text[] armaduraPrices;

    public Image[] armaduraSprites;


    void Awake()
    {
        instance = this;
    }
    
    public void AddItemArmas(ScriptableItems item)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            if(armas[i] == null)
            {
                armas[i] = item;
                armasNames[i].text = item.itemName;
                armasSprites[i].sprite = item.itemSprite;
                armasPrices[i].text = item.itemPrice.ToString();

                return;
            }
        }
    }

    public void AddItemarmadura(ScriptableItems item)
    {
        for (int i = 0; i < armadura.Length; i++)
        {
            if(armadura[i] == null)
            {
                armadura[i] = item;
                armaduraNames[i].text = item.itemName;
                armaduraSprites[i].sprite = item.itemSprite;
                armaduraPrices[i].text = item.itemPrice.ToString();

                return;
            }
        }
    }
}