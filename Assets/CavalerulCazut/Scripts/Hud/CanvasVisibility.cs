using CavalerulCazut;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVisibility : MonoBehaviour
{
    public GameObject panelToToggle; // Panoul pe care dorim să îl facem vizibil/invizibil
    public string targetTag = "BanditLeader"; // Eticheta țintă pentru obiectul BanditLeader

    private void Start()
    {
        // Asigurați-vă că panoul este inițial invizibil
        if (panelToToggle != null)
        {
            panelToToggle.SetActive(false);
        }
    }

    private void Update()
    {
        // Căutăm obiectele cu eticheta "BanditLeader" în scenă
        GameObject[] banditLeaders = GameObject.FindGameObjectsWithTag(targetTag);

        // Verificăm dacă nu mai există obiecte BanditLeader în scenă
        if (banditLeaders.Length == 0)
        {
            // Facem panoul vizibil dacă nu mai există BanditLeader
            if (panelToToggle != null)
            {
                panelToToggle.SetActive(true);
            }
        }
        else
        {
            // Dacă există obiecte BanditLeader în scenă, facem panoul invizibil
            if (panelToToggle != null)
            {
                panelToToggle.SetActive(false);
            }
        }
    }
}
