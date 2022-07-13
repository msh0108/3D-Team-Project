using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float degreePerSeconds = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = degreePerSeconds * Time.deltaTime;
        transform.Rotate(Vector3.up * speed);

    }
}