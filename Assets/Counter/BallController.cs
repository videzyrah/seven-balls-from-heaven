using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	private GameManager gameManager;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.Space)){
		 rb.useGravity = true;
		}
		if (transform.position.x < -5 || transform.position.x > 5 ){
		  Destroy(gameObject);
		}
    }
}
