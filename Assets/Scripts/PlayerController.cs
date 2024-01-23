using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    [SerializeField] private float speed = 30f;
    private float forwardInput;

    [SerializeField] private GameObject focalPointGameObject;


    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        forwardInput = Input.GetAxis("Vertical");

        playerRigidBody.AddForce(focalPointGameObject.transform.forward * speed * forwardInput);

    }

}
