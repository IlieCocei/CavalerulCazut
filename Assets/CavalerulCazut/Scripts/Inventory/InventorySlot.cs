using System;
using UnityEngine;

namespace CavalerulCazut
{
    [System.Serializable]
    public class InventorySlot
    {
        public int index;
        public string itemName;
        public GameObject itemPrefab;

        public InventorySlot(int index)
        {
            this.index = index;
        }

        public void Place(GameObject item)
        {
            itemName = item.name;
            itemPrefab = item;
        }
    }

}

