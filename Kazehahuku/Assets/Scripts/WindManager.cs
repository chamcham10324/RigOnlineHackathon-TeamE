using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    private AreaEffector2D windEffector;

    void Start()
    {
        windEffector = GetComponent<AreaEffector2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            windEffector.forceAngle = 90;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            windEffector.forceAngle = 270;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            windEffector.forceAngle = 180;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            windEffector.forceAngle = 0;
        }
    }
}
