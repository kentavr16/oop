using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject bullet;
    public float userInputHorizontal;
    private float userInputVertical;
    private Rigidbody playerRb;
    public float rotationSpeed = 100;
    public float moveSpeed;
    public Vector3 bulletVector;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();
        bulletVector = transform.GetChild(0).position - transform.position;
    }

    private void Move()
    {
        userInputHorizontal = Input.GetAxis("Horizontal");
        userInputVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (userInputVertical * -1)* moveSpeed* Time.deltaTime);
        transform.Rotate(Vector3.up * userInputHorizontal * rotationSpeed * Time.deltaTime);
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet,transform.position+ (bulletVector *2),bullet.transform.rotation);
        }
    }
    

}
