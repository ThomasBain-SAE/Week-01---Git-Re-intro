using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] isShooting = false;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButton(0))
        {
            // shooting
            isShooting = true;
        }
    
    
    
    
        if (Input.GetMouseButton(1))
        {
            // not shooting
            isShooting = false;
        }
    }
}
