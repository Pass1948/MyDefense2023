using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public LayerMask enemyMask;

    private void OnTriggerEnter(Collider other)
    {
        if (enemyMask.IsContaion(other.gameObject.layer))
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enemyMask.IsContaion(other.gameObject.layer))
        {

        }
    }
}
