using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerData", menuName = "Data/Tower")]
public class TowerData : ScriptableObject
{
    [SerializeField] TowerInfo[] towers;
    public TowerInfo[] Towers { get { return towers; } }


    [Serializable]
    public class TowerInfo
    {

        public Tower tower;

        public int damage;
        public float range;
        public float dellay;

        public float buildTime;
        public int buildCost;
        public int sellCost;
    }
}
