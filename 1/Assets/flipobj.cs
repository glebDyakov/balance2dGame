using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipobj : MonoBehaviour
{	//[Serialize Field]
	private bool right = false;
	private bool dright = true;
	public GameObject dplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	if(right==false && Input.GetKeyDown(KeyCode.RightArrow)){
flip();

}else if(right==true && Input.GetKeyDown(KeyCode.LeftArrow)){
flip();

}if(dright==false && Input.GetKeyDown(KeyCode.D)){
dflip();

}else if(dright==true && Input.GetKeyDown(KeyCode.A)){
dflip();

}
        
    }
	void flip(){
transform.localScale= new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
right=!right;
}void dflip(){
dplayer.transform.localScale= new Vector3(dplayer.transform.localScale.x * -1, dplayer.transform.localScale.y, dplayer.transform.localScale.z);
dright=!dright;
}
}
