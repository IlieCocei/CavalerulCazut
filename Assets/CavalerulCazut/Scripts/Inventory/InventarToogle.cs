using System.Collections;
using UnityEngine;

namespace Assets.CavalerulCazut.Scripts.Inventory
{
    public class InventarToogle : MonoBehaviour
    {

        private bool isInventoryVisible = false; // Inițial, inventarul este invizibil.

        // Referință la obiectul "InventoryUI" din ierarhia scenei.
        public GameObject inventoryUI;

        private void Update()
        {
            // Verifică dacă tasta "B" a fost apăsată.
            if (Input.GetKeyDown(KeyCode.B))
            {
                // Inversează starea variabilei "isInventoryVisible".
                isInventoryVisible = !isInventoryVisible;

                // Setează vizibilitatea obiectului "InventoryUI" în funcție de starea variabilei.
                inventoryUI.SetActive(isInventoryVisible);
            }
        }
    }
}