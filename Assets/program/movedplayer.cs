using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedplayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float speedx;
    public float speedy;
    private float horizontal;
    private float vertical;
    public GameObject bulletPrefab;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical"); 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

    void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(speedx * horizontal, speedy * vertical);
    }
}
