using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                                                                        
public class movingScript : MonoBehaviour {

    public LineRenderer lRend;
    public float speed = 05f;
    public float mousespeed = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float g = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        float h = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, g, 0);
        transform.Translate(0, 0, h);
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        **/
        float x = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;
        float y = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
        Vector3 v = new Vector3(x, y, 0);
        transform.Rotate(v);
        
    }
}
