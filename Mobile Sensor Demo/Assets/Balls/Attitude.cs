using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attitude : MonoBehaviour
{
    public bool isFlat = true;
    private Rigidbody rigid;

    private void Start() 
    {
        rigid = GetComponent<Rigidbody>();
    }
    
    private void Update() 
    {
        Vector3 tilt = Input.acceleration;
        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        if (isFlat)
            tilt = Quaternion.Euler(0, 90, 0) * tilt;


        rigid.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.red);
    }
}
