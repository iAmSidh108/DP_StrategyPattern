using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Projectile : MonoBehaviour
{
    // STRATEGY PATTERN - we want to change the projectile's flight pattern
    // at runtime - powerups? levelups? talent trees?
    IMovable _moveBehavior;

    [SerializeField] float _travelSpeed = 10;
    public float TravelSpeed => _travelSpeed;

    Rigidbody _rb = null;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        // establish our initial projectile movement behavior
        _moveBehavior = new LinearMovement(_rb, _travelSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Projectile collision");
        //TODO check for damageable
        //Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        _moveBehavior.Move();
    }

    public void SetMoveBehavior(IMovable newMoveBehavior)
    {
        Debug.Log("Changing projectile flight behavior!");
        _moveBehavior = newMoveBehavior;
    }
}
