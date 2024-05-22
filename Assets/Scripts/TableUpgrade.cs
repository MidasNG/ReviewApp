using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableUpgrade : Upgradeable
{
    [SerializeField] private UpgradeManager upgradeManager;
    [SerializeField] private int upgradeableID;
    [SerializeField] private Mesh upgradeMesh;

    public override void OnUpgradeRecieved(int _upgradeableID)
    {
        if(upgradeableID == _upgradeableID) GetComponent<MeshFilter>().mesh = upgradeMesh;
    }

    private void Awake()
    {
        if (upgradeManager != null)
        {
            upgradeManager.UpgradeRecieved += OnUpgradeRecieved;
        }
    }
}
