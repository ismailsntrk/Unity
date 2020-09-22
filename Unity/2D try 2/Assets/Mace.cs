using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    public float health = 100;
    public Transform transform;
    public Vector3 vec3;
    public float range;
  
    public void takeDamage(int damage)
    {
        health -= damage;
        transform.position = vec3;
        vec3.x += range;
        vec3.y += range;
        vec3.z += range;

        Instantiate(gameObject, vec3, transform.rotation);
        Destroy(gameObject);
        if (health<= 0)
        {
            Die();
        }


    }
    public void Die()
    {
        Destroy(gameObject);
    }

   

 
    
}
