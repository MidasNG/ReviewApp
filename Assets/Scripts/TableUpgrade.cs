using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableUpgrade : Upgradeable
{
    [SerializeField] private UpgradeManager upgradeManager;
    [SerializeField] private int upgradeableID;
    [SerializeField] private GameObject nextVersion;

    public override void OnUpgradeRecieved(int _upgradeableID)
    {
        if (upgradeableID == _upgradeableID && nextVersion != null)
        {
            //La rotacion se indica en el prefab de la siguiente mesa
            Instantiate(nextVersion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        if (upgradeManager != null)
        {
            upgradeManager.UpgradeRecieved += OnUpgradeRecieved;
        }
    }
}
