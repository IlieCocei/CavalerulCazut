using CavalerulCazut;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRegenerare : MonoBehaviour
{
    public Damageable playerDamageable;
    public float regenerationInterval = 5.0f;
    public int regenerationAmount = 10;

    private float timer = 0.0f;

    private void Start()
    {
        timer = regenerationInterval;
    }

    private void Update()
    {
        // Verificați dacă jucătorul are viața sub maxim
        if (playerDamageable.CurrentHitPoints < playerDamageable.maxHitPoints)
        {
            timer -= Time.deltaTime;

            // Verificați dacă a trecut intervalul de regenerare
            if (timer <= 0)
            { 
                // Calculează noua valoare a vieții
                int newHitPoints = playerDamageable.CurrentHitPoints + regenerationAmount;

                // Asigurați-vă că noua valoare nu depășește maximul
                newHitPoints = Mathf.Min(newHitPoints, playerDamageable.maxHitPoints);

                // Folosiți metoda SetCurrentHitPoints pentru a seta noua valoare a vieții
                playerDamageable.SetCurrentHitPoints(newHitPoints);

                timer = regenerationInterval;
            }
        }
    }
}
