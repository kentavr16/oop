using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private Rigidbody enemyRB;
    private Vector3 moveVector;
    private float speed=40;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyRB = GetComponent<Rigidbody>();

        player = GameObject.Find("Player");

        Move();
    }
    private void Move()
    {
        moveVector = transform.position - player.transform.position;
       // transform.Translate(-moveVector * speed * Time.deltaTime);
       enemyRB.AddForce(-moveVector * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
