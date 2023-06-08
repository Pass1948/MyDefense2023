using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchorTower : Tower
{
    protected override void Awake()
    {
        data = GameManager.Resource.Load<TowerData>("Data/ArchorTowerData");
    }
}
