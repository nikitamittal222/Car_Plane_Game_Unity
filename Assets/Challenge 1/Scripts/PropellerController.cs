using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    private float spinSpeed = 10000.0f;  // Speed of rotation
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its local Z-axis at a constant rate
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}