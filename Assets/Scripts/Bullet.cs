using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 m_bulletVector;
    private float bulletSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(m_bulletVector == null || m_bulletVector == new Vector3(0,0,0))
        {
            m_bulletVector = GameObject.Find("Player").GetComponent<PlayerControl>().bulletVector;
        }

        transform.Translate(m_bulletVector * Time.deltaTime * bulletSpeed , Space.World);

    }
}
