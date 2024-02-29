using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccleratedMovement : IMovable
{
    float _currentSpeed;
    Rigidbody _rb;
    float _accelerateSpeed;
    Transform _objectTransform;

    public AccleratedMovement(Rigidbody rb, float accelerateSpeed)
    {
        _currentSpeed = 0;
        _rb = rb;
        _accelerateSpeed = accelerateSpeed;
        _objectTransform = _rb.transform;
    }

    public void Move()
    {
        // this assumes we're calling Move in FixedUpdate - kinda hacky
        _currentSpeed += _accelerateSpeed;
        _rb.velocity = _objectTransform.forward * _currentSpeed;
    }
}
