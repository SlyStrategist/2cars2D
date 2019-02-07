using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r_e_car : MonoBehaviour
{
    private float init_speed;
    private float tspeed;
    private float m_gradient;
    // Start is called before the first frame update
    void Start()
    {
        init_speed = -2;
        m_gradient = (float)-500;
        tspeed = varSpeed();
      
    }

    // Update is called once per frame
    void Update()
    {
        tspeed = varSpeed();
        transform.Translate(new Vector3(0, 1, 0) * tspeed * Time.deltaTime);
        
    }

    private float varSpeed()
    {
        return ( Mathf.Clamp((float)Bg_move.time * m_gradient + init_speed, -5000, -2));
    }
}
