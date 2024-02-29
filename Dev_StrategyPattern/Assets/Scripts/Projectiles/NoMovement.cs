using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMovement : IMovable
{
    Rigidbody _rb;

    public NoMovement(Rigidbody rb)
    {
        _rb = rb;
        // kill current velocity
        _rb.velocity = Vector3.zero;
    }

    public void Move()
    {
        // no movement! This is basically the NullObject Pattern
    }
}
