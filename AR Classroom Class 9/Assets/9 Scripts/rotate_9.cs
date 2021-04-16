using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_9 : MonoBehaviour
{
    public float speed_x = 0f;
    public float speed_y = 0f;
    public float speed_z = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * speed_x, 0, 0);
        transform.Rotate(0, Time.deltaTime * speed_y, 0);
        transform.Rotate(0, 0, Time.deltaTime * speed_z);
    }
}
