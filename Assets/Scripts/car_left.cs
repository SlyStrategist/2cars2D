using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_left : MonoBehaviour
{
    public float CarSpeed;
    public float maxpos;
    public float minpos;
    Vector3 Position;

    // Start is called before the first frame update
    void Start()
    {
        Position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Position.x += CarSpeed * Time.deltaTime;
            Position.x = Mathf.Clamp(Position.x, minpos, maxpos);
            transform.position = Position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Position.x -= CarSpeed * Time.deltaTime;
            Position.x = Mathf.Clamp(Position.x, minpos, maxpos);
            transform.position = Position;

        }

      
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);

        }
    }
}
