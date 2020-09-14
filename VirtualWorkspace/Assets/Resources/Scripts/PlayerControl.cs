using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : NetworkBehaviour
{
    public float speed = 30;
    public Rigidbody2D rigidbody2d;


    void FixedUpdate()
    {
        if (isLocalPlayer)
            rigidbody2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.fixedDeltaTime;
    }
}
