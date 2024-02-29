using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : IMovable
{
    float _travelSpeed;
    Rigidbody _rb = null;
    Transform _objectTransform = null;

    public LinearMovement(Rigidbody rb, float travelSpeed)
    {
        _rb = rb;
        _travelSpeed = travelSpeed;
        _objectTransform = _rb.transform;
    }

    public void Move()
    {
        _rb.velocity = _objectTransform.forward * _travelSpeed;
    }
}
