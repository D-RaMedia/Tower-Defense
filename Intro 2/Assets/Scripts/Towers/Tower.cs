using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected EnemyRangeChecker _rangeChecker;
    private Enemy _target;
    private Enemy _enemies;
    // Start is called before the first frame update
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyRangeChecker>();
        Debug.Log(GetComponent<EnemyRangeChecker>());
    }

    void Update()
    {
        // als we niet kunnen aanvallen, Ga dan uit de update functie
        if (!CanAttack()) return;
        
        Attack();
    }

    protected virtual bool CanAttack()
    {
        return false;
    }

    protected virtual void Attack()
    {

    }
}