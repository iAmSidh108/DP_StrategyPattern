using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Projectile incomingProjectile =
            other.gameObject.GetComponent<Projectile>();
        // if it's a valid projectile, apply a new movement behavior
        if (incomingProjectile != null)
        {
            NoMovement noMoveBehavior = new NoMovement(other.attachedRigidbody);
            incomingProjectile.SetMoveBehavior(noMoveBehavior);
        }
    }
}
