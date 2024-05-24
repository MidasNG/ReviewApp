using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgradeable : MonoBehaviour
{
    //Cada clase que hereda de esta, debe implementar 'public override void OnUpgradeRecieved()'
    //Cada tipo objeto a mejorar tiene un valor concreto para saber que se tiene que mejorar ese y no otro (como mesa con ID 0)
    public abstract void OnUpgradeRecieved(int _upgradeableID);
}