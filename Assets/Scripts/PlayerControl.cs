using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float userInputHorizontal;
    private float userInputVertical;
    private Rigidbody playerRb;
    public float rotationSpeed = 100;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        userInputHorizontal = Input.GetAxis("Horizontal");
        userInputVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (userInputVertical * -1)* moveSpeed* Time.deltaTime);
        transform.Rotate(Vector3.up * userInputHorizontal * rotationSpeed * Time.deltaTime);
    }
}
