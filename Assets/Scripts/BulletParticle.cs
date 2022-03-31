using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticle : MonoBehaviour
{
    public float damage = 1f;
    public ParticleSystem particleSystem;

    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();


    private void OnParticleCollision(GameObject other)
    {
        //int events = particleSystem.GetCollisionEvents(other, colEvents);


        //if(other.transform.root.TryGetComponent(out Enemy en))
        //{
        //     en.TakeDamage(damage);
        //}


        if (other.gameObject != null)
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}