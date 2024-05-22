using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private BalanceManager balanceManager;

    public event Action<int> UpgradeRecieved;

    public void Upgrade(int upgradeableID)
    {
        if (balanceManager.upgradesAvailable > 0)
        {
            UpgradeRecieved?.Invoke(upgradeableID);

            print("Mejora realizada con ID " + upgradeableID + "!");

            balanceManager.UpgradeFinished();
        }
        else print("No hay mejoras disponibles!");
    }
}
