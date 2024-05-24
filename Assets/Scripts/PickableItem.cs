using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItems item;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.layer == 3)
            {
                InventoryManager.instance.AddItemArmas(item);
            }
            else if (gameObject.layer == 6)
            {
                InventoryManager.instance.AddItemarmadura(item);
            }

            Destroy(this.gameObject);
        }
    }
}