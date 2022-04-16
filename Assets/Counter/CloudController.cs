using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
	private float horizontalInput;
	public float lateralSpeed = 5.0f;
	private GameManager gameManager;
	private bool isReleased = false;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.Space)){
		 isReleased = true;
		}
		 
		if(isReleased == false){
          // Move the cloud with arrow keys / wasd
		  horizontalInput = Input.GetAxis("Horizontal");
		  //forwardInput = Input.GetAxis("Vertical");
		  //transform.Translate(Vector3.forward * Time.deltaTime * lateralSpeed * forwardInput*10);
		  transform.Translate(Vector3.forward * Time.deltaTime * lateralSpeed * horizontalInput);
		}
		
    }
}
