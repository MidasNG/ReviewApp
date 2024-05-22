using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgradeable : MonoBehaviour
{
    public abstract void OnUpgradeRecieved(int _upgradeableID);
}