using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg_move : MonoBehaviour
{
    public float Speed;
    public float constant;
    public float Gradient;
    private float tspeed = 0;
    public static double time;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        tspeed = Speed;
        time = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (tspeed < constant)
        {
            tspeed += Gradient * Time.deltaTime;
            offset = new Vector2(0, Time.time * tspeed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }

        if (tspeed >= constant)
        {
            tspeed += Speed * Time.deltaTime;
            offset = new Vector2(0, Time.time * tspeed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;

        }
        time = Time.deltaTime;


    }
}
