using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float up = Input.GetAxis("Vertical");
        if (up != 0)
        {
            var pos = transform.position;
            pos += Vector3.up * up * Time.deltaTime * 200;
            rigidbody.MovePosition(pos);
        }
        float right = Input.GetAxis("Horizontal");
        if (right != 0)
        {
            var pos = transform.position;
            pos += Vector3.right * right * Time.deltaTime * 50;
            rigidbody.MovePosition(pos);
        }
    }
}
