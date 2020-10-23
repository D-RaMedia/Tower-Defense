using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangeChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    // Start is called before the first frame update
    public Enemy GetFirstEnemyInRange()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, _radius);
        if(cols.Length < 1)
        return null;

        return cols[0].GetComponent<Enemy>();
    }

    public Enemy[] GetallEnemiesInRange()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, _radius);
        if (cols.Length < 1)
            return null;

        List<Enemy> enemiesInRange = new List<Enemy>();
        foreach(var col in cols)
        {
            enemiesInRange.Add(col.GetComponent<Enemy>());
        }

        return enemiesInRange.ToArray();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
