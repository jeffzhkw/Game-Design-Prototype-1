using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundTo : MonoBehaviour
{
    public Vector3 rotateCenter;
    public float radius;
    public float angularSpeed;

    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        print(rotateCenter);
        print(radius);
        print(angularSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        angle += angularSpeed;
        transform.localPosition = new Vector3(radius*Mathf.Cos(angle), radius * Mathf.Sin(angle), 0);
        //transform.Rotate(transform.position, angle);
    }
}
