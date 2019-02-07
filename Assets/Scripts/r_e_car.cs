using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r_e_car : MonoBehaviour
{
    public float speed;
    public float grad;
    public float terminal;
    float tspeed;
    // Start is called before the first frame update
    void Start()
    {
        tspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {

        if (tspeed < terminal)
        {
            tspeed = tspeed + grad * Time.deltaTime;
            transform.Translate(new Vector3(0, 1, 0) * tspeed * Time.deltaTime);

        }
        
        else
        {
            tspeed = terminal;
            transform.Translate(new Vector3(0, 1, 0) * tspeed * Time.deltaTime);

        }



        
        
    }
}
