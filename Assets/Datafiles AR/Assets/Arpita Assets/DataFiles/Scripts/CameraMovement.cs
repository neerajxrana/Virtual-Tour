using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveCam = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0,0,moveCam);

        float rotateCam = 0;
        float up_down = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateCam = rotateCam - 1;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateCam = rotateCam + 1;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            up_down = up_down + 1; 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            up_down = up_down - 1;
        }

        transform.Rotate(0, rotateCam, 0);

        transform.Rotate(up_down, 0, 0);
    }
}
