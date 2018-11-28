using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTrack : MonoBehaviour {
    float pokeForce=100;
    public int x = 2, y = 2  ;
    public AudioSource audio;
    public AudioClip audioClip;
    public LayerMask layerMask;
    public float clipVolume;
    public Camera mainCamera;
	// Use this for initialization
	void Start () {
        mainCamera = GetComponent<Camera>();
        
    }
	
	// Update is called once per frame
	void Update () {
        


        

        int i = 1, j = 1;
        while(i <= x)
        {
            
            while (j <= y)
            {
                var ray = Camera.main.ScreenPointToRay(new Vector2((mainCamera.pixelWidth / (x + 1)) * i, (mainCamera.pixelHeight / (y + 1)) * j));
              
                RaycastHit hit;
                
                if (Physics.Raycast(ray , out hit))
                {
                   
                    if (hit.point != null && hit.transform.gameObject.tag != "no sound" )
                    {

                       
                        float dist = hit.distance;
                        if (!audio.isPlaying)
                        {
                            AudioSource.PlayClipAtPoint(audioClip, hit.point, clipVolume);
                            
                        }
                     
              
                     
                    } 
                }
                j++;
            }
            j = 1;
            i++;
        }
    }

    void OnGUI()
    {
        
                GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 10, 10), "");
        
    }

}
