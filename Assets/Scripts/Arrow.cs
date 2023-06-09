using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private EnemyController enemy;
    private Vector3 targerPoint;
    [SerializeField] float speed;
    private int damage;
    public void SetTarget(EnemyController enemy)
    {
        this.enemy = enemy;
        targerPoint = enemy.transform.position;
        StartCoroutine(ArrowRoutine());
    }

    public void SetDamage(int damage)
    {
        this.damage = damage;
    }

   
    IEnumerator ArrowRoutine()
    {
        while (true)
        {
            if (enemy != null)
                targerPoint = enemy.transform.position;

            transform.LookAt(targerPoint);
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

            if (Vector3.Distance(targerPoint, transform.position)< 0.1f)
            {
                if (enemy != null)
                Attack(enemy);  

                GameManager.Resource.Destroy(gameObject);
                yield break;    
            }
            yield return null;
        }
    }

    public void Attack(EnemyController enemy)
    {
        enemy.TakeHit(damage);
    }
}
