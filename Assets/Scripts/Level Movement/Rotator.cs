using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 0.00f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime * speed);
    }
}
