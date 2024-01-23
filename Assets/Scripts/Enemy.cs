using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidBody;
    private GameObject playerGoal;

    [SerializeField] private float speed = 2.5f;

    void Awake()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        playerGoal = GameObject.Find("Player Goal");
    }

    private void Update()
    {
        GoToGoal();
    }

    private void GoToGoal()
    {
        Vector3 direction = (playerGoal.transform.position - transform.position).normalized;
        enemyRigidBody.AddForce(direction * speed);

    }

}
