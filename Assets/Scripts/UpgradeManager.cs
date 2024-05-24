using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private BalanceManager balanceManager;

    public event Action<int> UpgradeRecieved;

    //Cada mejora puede hacer algo diferente, por lo que que cada objeto que se puede mejorar debe tener una clase que hereda de la clase Upgradeable
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
