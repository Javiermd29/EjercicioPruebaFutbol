using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCmaera : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private GameObject player;

    private float horizontalInput;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

    }
}
