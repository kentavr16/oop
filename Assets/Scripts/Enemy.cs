using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Vector3 moveVector;
    private float speed=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        moveVector = transform.position - player.transform.position;
        transform.Translate(-moveVector * speed * Time.deltaTime);
    }
}
