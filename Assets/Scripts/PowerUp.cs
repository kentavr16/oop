using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Enemy
{
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    public override void CollisionBehavior(Collider other)
    {
        
    }

}
