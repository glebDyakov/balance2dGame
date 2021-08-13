using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
public GameObject btn;
Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        btn=GetComponent<GameObject>();
	anim=GetComponent<Animator>();
    }

    // Update is called once per frame
   /* void Update()
    {
	//Button.clicked();
        //btn.transform.Translate(-Vector2.right*0.02f);
	//btn.transform.Translate(-Vector2.right*0.02f);
    }*/
	void OnMouseDown(){
	btn.transform.Translate(-Vector2.right*0.02f);
}
	void onClick(){
	print("123");
}
	public void Cli(){
	print("11111");
}
	public void SendMessage(string a){
	print(a);
	anim.SetInteger("anima",1);
	anim.SetInteger("anima",1);
}

}
