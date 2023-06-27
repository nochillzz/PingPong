using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 5f;

    private void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalInput) * speed;
    }
}
