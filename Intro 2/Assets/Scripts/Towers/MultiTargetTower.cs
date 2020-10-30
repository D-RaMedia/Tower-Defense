using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargetTower : Tower
{
    private Enemy[] _enemies;
    public Enemy enemy;

    protected override bool CanAttack()
    {
        _enemies = _rangeChecker.GetallEnemiesInRange();
        if(_enemies != null)
        {
            if(_enemies.Length >= 20)
            {
                return true;
            }
        }
        return false;
    }

    protected override void Attack()
    {
        foreach (var enemy in _enemies)
        {
            //Debug.Log("MuliTargetTower >> Val deze vijand aan: " + enemy);
        }
    }
}
