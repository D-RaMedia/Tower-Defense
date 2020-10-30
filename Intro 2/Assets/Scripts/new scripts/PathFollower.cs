using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class PathFollower : PlayerHealth
{
    [SerializeField] public UnityEvent pathEnd;
    [SerializeField] private Path path;
    [SerializeField] private float speed = 5f;

    void Update()
    {
        if (path.GetCurrentWayPoint().Equals(null)) return;

        Vector3 targetPos = path.GetCurrentWayPoint().Position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position != targetPos) return;

        End();
    }

    public void End()
    {
        if (path.Next()) return;
        TakenDamage(20);
        pathEnd.Invoke();
        Destroy(this.gameObject);
    }
}
