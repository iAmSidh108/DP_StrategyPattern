using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowWall : MonoBehaviour
{
    [SerializeField] float _accelerateAmount = .2f;

    private void OnTriggerEnter(Collider other)
    {
        Projectile incomingProjectile =
            other.gameObject.GetComponent<Projectile>();
        // if it's a valid projectile, apply a new movement behavior
        if (incomingProjectile != null)
        {
            AccleratedMovement slowStart = new AccleratedMovement
                (other.attachedRigidbody, _accelerateAmount);
            incomingProjectile.SetMoveBehavior(slowStart);
        }
    }
}
