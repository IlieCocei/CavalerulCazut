using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

namespace CavalerulCazut
{
    public class PlayerStats : MonoBehaviour, IMessageReceiver
    {
        public int maxLevel;
        public int currentLevel;
        public int currentExp;
        public int[] availableLevels;
        public Text nivelText;

        public Damageable CresteViata;

        public int ExperienceToNextLevel
        {
            get
            {
                return availableLevels[currentLevel] - currentExp;
            }
        }

        private void Start()
        {
            // Actualizați textul nivelului la începutul jocului
            UpdateLevelText();
        }

        private void Awake()
        {
            availableLevels = new int[maxLevel];
            ComputeLevels(maxLevel);
        }

        private void ComputeLevels(int levelCount)
        {
            for (int i = 0; i < levelCount; i++)
            {
                var level = i + 1;
                var levelPow = Mathf.Pow(level, 2);
                var expToLevel = Convert.ToInt32(levelPow * levelCount);
                availableLevels[i] = expToLevel;
            }
        }

        public void OnReceiveMessage(MessageType type, object sender, object msg)
        {
            if (type == MessageType.DEAD)
            {
                GainExperience((sender as Damageable).experience);
            }
        }

        public void GainExperience(int gainedExp)
        {
            if (gainedExp > ExperienceToNextLevel)
            {
                var remainderExp = gainedExp - ExperienceToNextLevel;
                currentExp = 0;
                currentLevel++;
                GainExperience(remainderExp);
                CresteViata.SetInitialHealth();
                // Actualizați MaxHitPoints pe baza nivelului
                if (currentLevel <= maxLevel)
                {
                    CresteViata.maxHitPoints += 10; // De exemplu, creșteți MaxHitPoints cu 10 la fiecare nivel
                }
                // După ce s-a schimbat nivelul, actualizez textul
                UpdateLevelText();
            }
            else if (gainedExp == ExperienceToNextLevel)
            {
                currentLevel++;
                currentExp = 0;

                CresteViata.SetInitialHealth();
                // actualizați MaxHitPoints pe baza nivelului
                if (currentLevel <= maxLevel)
                {
                    CresteViata.maxHitPoints += 10; // creșteți MaxHitPoints cu 10 la fiecare nivel
                }
                UpdateLevelText();
            }
            else
            {
                currentExp += gainedExp;
            }


        }


        private void UpdateLevelText()
        {
            if (nivelText != null)
            {
                nivelText.text = "Nivel: " + currentLevel.ToString(); // Actualizați textul cu nivelul actual
            }
        }
    }
}
