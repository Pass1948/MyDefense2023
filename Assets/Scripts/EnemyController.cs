using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    [SerializeField]private int hp;
    public int HP { get { return hp; } private set { hp = value; OnChangedHP?.Invoke(HP); } }
    public UnityEvent<int> OnChangedHP;
    public UnityEvent OnDied;

    public void TakeHit(int damage)
    {
        HP -= damage;

        if (HP <= 0)
        {
            OnDied?.Invoke();
            GameManager.Resource.Destroy(gameObject);
        }
        
    }
}
