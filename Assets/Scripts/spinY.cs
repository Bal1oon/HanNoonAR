using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinY : MonoBehaviour
{
    public float freq;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, freq * Time.deltaTime, 0f, Space.Self);
    }
}