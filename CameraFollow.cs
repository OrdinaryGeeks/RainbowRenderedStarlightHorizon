using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject starlight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = starlight.transform.position + new Vector3(0.0f, 24.0f, 0.0f);
    }
}
