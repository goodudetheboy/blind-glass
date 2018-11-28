using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCamera : MonoBehaviour {
    public float speed = 10;
    public Camera MyCamera;
    public Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = MyCamera.transform.forward * moveVertical * speed * Time.deltaTime;
        transform.position += movement;
        movement = MyCamera.transform.right * moveHorizontal * speed * Time.deltaTime;
        transform.position += movement;
        
   
    }
}
