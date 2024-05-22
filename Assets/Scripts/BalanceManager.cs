using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BalanceManager : MonoBehaviour
{
    private int balance;

    [SerializeField] private TextMeshProUGUI upgradesAvailableText;

    public int upgradesAvailable { get; private set; }

    private List<(int, bool)> thresholds = new List<(int, bool)>
    { 
        { (10, false) },
        { (25, false) },
        { (50, false) },
        { (100, false) } 
    };

    [SerializeField] private GameObject upgradeChoice;

    public void RaiseBalance(int amount)
    {
        balance += amount;
        for (int i = 0; i < thresholds.Count; i++)
        {
            if (!thresholds[i].Item2 && balance >= thresholds[i].Item1)
            {
                thresholds[i] = (thresholds[i].Item1, true);
                upgradesAvailable++;
                upgradesAvailableText.text = "Mejoras disponibles: " + upgradesAvailable.ToString();

                print(upgradesAvailable + " mejoras disponibles!");
            }
        }
    }

    public void UpgradeFinished()
    {
        upgradesAvailable--;
        upgradesAvailableText.text = "Mejoras disponibles: " + upgradesAvailable.ToString();
    }
}
