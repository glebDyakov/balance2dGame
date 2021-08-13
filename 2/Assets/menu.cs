using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{	public GameObject txt1;
	public GameObject txt2;
	public GameObject bg;
	//static bool start=false;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        txt1.SetActive(false);
	txt2.SetActive(false);
	bg.SetActive(false);
	//!platforms.start;
	//start=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
