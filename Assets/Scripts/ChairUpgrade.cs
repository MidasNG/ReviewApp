using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairUpgrade : Upgradeable
{
    [SerializeField] private UpgradeManager upgradeManager;
    [SerializeField] private int upgradeableID;

    public override void OnUpgradeRecieved(int _upgradeableID)
    {
        if (upgradeableID == _upgradeableID) transform.localScale = new Vector3( 30, 30, 30);
    }

    private void Awake()
    {
        if (upgradeManager != null)
        {
            upgradeManager.UpgradeRecieved += OnUpgradeRecieved;
        }
    }
}
