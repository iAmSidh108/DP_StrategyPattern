using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShot : WeaponBase
{
    public override void Shoot()
    {
        //TODO use Object Pooling for optimization
        //TODO use Template Method to put default shoot in baseclass
        Debug.Log("Shoot Launcher - BOOM!");
        // spawn projectile
        Projectile newProjectile = Instantiate
                (Projectile, ProjectileSpawnLocation.position,
                ProjectileSpawnLocation.rotation);

        // play particles
        ParticleSystem burstParticle = Instantiate
            (ShootParticle, ProjectileSpawnLocation.position,
            Quaternion.identity);
        burstParticle.Play();

        // play audio
        AudioSource.PlayClipAtPoint(ShootSound, ProjectileSpawnLocation.position);
    }
}
