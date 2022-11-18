using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 m_bulletVector;
    private float bulletSpeed = 50;
    private float boundary = 55;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        BulletFly();

        BulletBoundary();
    }

    private void BulletFly()
    {
        if (m_bulletVector == null || m_bulletVector == new Vector3(0, 0, 0))
        {
            m_bulletVector = GameObject.Find("Player").GetComponent<PlayerControl>().bulletVector;
        }

        transform.Translate(m_bulletVector * Time.deltaTime * bulletSpeed, Space.World);

    }

    private void BulletBoundary()
    {
        if (transform.position.x > boundary || transform.position.x < -boundary || transform.position.z > boundary || transform.position.z < -boundary)
        {
            Destroy(gameObject);
        }

    }
}
