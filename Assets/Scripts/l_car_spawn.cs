﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_car_spawn : MonoBehaviour
{
    public GameObject[] car;
    public float MaxPos;
    public float MinPos;
    public float delays;
    float timer;
    int number;
    float Avg;

    // Start is called before the first frame update
    void Start()
    {
        Avg = (MaxPos + MinPos) / 2;
        timer = Random.Range(delays, delays+1);




    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(delays - (float)0.5, delays+1);
            number = Random.Range(0, 8);

            if (Random.Range(MinPos, MaxPos) < Avg)
            {
                Vector3 carpos = new Vector3(MinPos, transform.position.y, transform.position.z);
                Instantiate(car[number], carpos, transform.rotation);

            }

            else
            {
                Vector3 carpos = new Vector3(MaxPos, transform.position.y, transform.position.z);
                Instantiate(car[number], carpos, transform.rotation);

            }

        }




    }
}
