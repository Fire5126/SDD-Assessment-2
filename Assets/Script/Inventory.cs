using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<ModifiableItems> items;
    [SerializeField] Transform itemsParent;
    [SerializeField] ItemSlot[] itemsSlots;

    private void OnValidate()
    {
        if (itemsParent != null)
        {
            itemsSlots = itemsParent.GetComponentsInChildren<ItemSlot>();
        }

        RefreshUI();
    }

    private void RefreshUI()
    {
        int i = 0;
        for (; i < items.Count && i < itemsSlots.Length; i++)
        {
            itemsSlots[i].Item = items[i];
        }

        for (; i < itemsSlots.Length; i++)
        {
            itemsSlots[i].Item = null;
        }
    }

    public bool AddItem(ModifiableItems item)
    {
        if (isFull())
        {
            return false;
        }

        items.Add(item);
        RefreshUI();
        return true;
    }

    public bool RemoveItem(ModifiableItems item)
    {
        if (items.Remove(item))
        {
            RefreshUI();
            return true;
        }
        return false;
    }

    public bool isFull()
    {
        return items.Count >= itemsSlots.Length;
    }


}
