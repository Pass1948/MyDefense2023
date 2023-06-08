using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected TowerData data;

    protected virtual void Awake()
    {
        data = GameManager.Resource.Load<TowerData>("Data/TowerData");
    }
}
