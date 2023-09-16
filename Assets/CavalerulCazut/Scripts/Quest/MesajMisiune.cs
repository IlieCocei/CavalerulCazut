using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MesajMisiune : MonoBehaviour
{
    public Text messageText;
    private bool showMessage = false;
    private float showTime = 2f; // Durata de afișare a mesajului în secunde

    private void Start()
    {
        // Inițial, mesajul trebuie să fie invizibil
        messageText.gameObject.SetActive(false);
    }

    // Funcția pentru afișarea mesajului
    public void ShowMessage(string message)
    {
        messageText.text = message;
        messageText.gameObject.SetActive(true);
        showMessage = true;

        // Dezactivează mesajul după showTime secunde
        Invoke("HideMessage", showTime);
    }

    private void Update()
    {
        // Dacă showMessage este activ, ține evidența timpului
        if (showMessage)
        {
            // Aici puteți adăuga orice efecte suplimentare sau logică de afișare
            // În acest exemplu, mesajul este doar activat/dezactivat și nu se efectuează animații

            // Dacă doriți să adăugați efecte de animație, ar trebui să utilizați Coroutines.
        }
    }

    // Funcția pentru ascunderea mesajului
    private void HideMessage()
    {
        messageText.gameObject.SetActive(false);
        showMessage = false;
    }
}
