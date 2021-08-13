using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
	void OnMouseDrag (){
Vector3 mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
gameObject.transform.position=new Vector2(mousepos.x,mousepos.y);
} //if(Input.GetKey(KeyCode.R)){ 
//print("1231321");
//}
}
