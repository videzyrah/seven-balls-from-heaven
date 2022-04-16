using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
	private Rigidbody bumperRb;
    // Start is called before the first frame update
    void Start()
    {
       bumperRb = GetComponent<Rigidbody>();
	   bumperRb.AddTorque(5,0,0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
