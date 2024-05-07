using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceUpwards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This ensures that the effect's rotation is always zero relative to the world, i.e., it always faces up
       transform.rotation = Quaternion.Euler(212,86, -90);
    }
}
