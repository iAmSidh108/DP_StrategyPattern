using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    // Strategy Pattern with an abstract class
    // using an abstract method... new weapons define shoot behavior!
    public abstract void Shoot();

    // with classes you can add lots of base attributes
    // while still retaining abstract behavior

    [SerializeField] Projectile _projectile = null;
    protected Projectile Projectile => _projectile;

    [SerializeField] Transform _projectileSpawnLocation = null;
    protected Transform ProjectileSpawnLocation => _projectileSpawnLocation;

    [SerializeField] ParticleSystem _shootParticle = null;
    protected ParticleSystem ShootParticle => _shootParticle;

    [SerializeField] AudioClip _shootSound = null;
    protected AudioClip ShootSound => _shootSound;
}
