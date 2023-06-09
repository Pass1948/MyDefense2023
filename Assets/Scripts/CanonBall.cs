using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{

    [SerializeField] float time;
    [SerializeField] float range;

    private Vector3 targerPoint;
    private int damage;

    public void SetTarget(EnemyController enemy)
    {
        targerPoint = enemy.transform.position;
        StartCoroutine(CanonRountine());
    }

    public void SetDamage(int damage)
    {
        this.damage = damage;
    }


    IEnumerator CanonRountine()
    {
        float xSpeed = (targerPoint.x - transform.position.x) / time;
        float zSpeed = (targerPoint.z - transform.position.z) / time;
        float ySpeed = -1 * (0.5f * Physics.gravity.y * time * time + transform.position.y) / time;

        float curTime = 0;
        while (curTime < time)
        {

            curTime += Time.deltaTime;
            ySpeed += Physics.gravity.y * Time.deltaTime;

            transform.position += new Vector3(xSpeed, ySpeed, zSpeed) * Time.deltaTime;
            yield return null;
        }
        Explosion();
        GameManager.Resource.Destroy(gameObject);   
    }

    public void Explosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("Enemy"));
        foreach(Collider collider in colliders)
        {
            EnemyController enemy = collider.GetComponent<EnemyController>();
            enemy?.TakeHit(damage);
        }
    }
    private void OnDrawGizmosSeleted()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
