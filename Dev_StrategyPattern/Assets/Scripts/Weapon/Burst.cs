using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burst : WeaponBase
{
    public override void Shoot()
    {
        //TODO use Object Pooling for optimization
        //TODO use Template Method to put default shoot in baseclass
        Debug.Log("Shoot the Blaster - Bang!");
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
