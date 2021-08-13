using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ft : MonoBehaviour
{	
	public GameObject cube;
	
	bool click;
	
	Rigidbody2D rb; 
	public GameObject obj;
	public GameObject obj3;
	private int ran;
	private int y;
	Animator anim;
    // Start is called before the first frame update
    void Start()
    {   
	click=false;
	//obj=GetComponent<GameObject>();
	rb=GetComponent<Rigidbody2D>();
	y=2;
	ran=Random.Range(1,3);
	anim=GetComponent<Animator>();
	//InvokeRepeating("create",2f,2f);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if(y==y){
print("Победа 2");
//rb.AddForce(transform.up * 2f, ForceMode2D.Impulse);
//anim.SetInteger("anim",1);
//obj.transform.Translate(-Vector2.right*0.02f);
click=!click;
print("123");
}}
    
	
void OnCollisionEnter2D(Collision2D other){
if(other.gameObject.tag=="r" ){
click=false;
//obj.transform.scale= new Vector3(-1f,0f,0f);
} 
if(other.gameObject.tag=="l" ){
click=true;
//obj.transform.scale= new Vector3(1f,0f,0f);
}
}


	void Update(){
if(Input.GetKey(KeyCode.M)){
	Application.LoadLevel("SampleScene");
}

/*obj.transform.Translate(Vector2.right*0.02f);
if(click==false){
obj.transform.position+=new Vector3(0.02f,0f,0f);

}
if(click==true){ 
obj.transform.position-=new Vector3(0.02f,0f,0f);
} */
if(Input.GetKey(KeyCode.RightArrow)){ 
obj.transform.position+=new Vector3(0.02f,0f,0f);
}
if(Input.GetKey(KeyCode.LeftArrow)){ 
obj.transform.position-=new Vector3(0.02f,0f,0f);
}if(Input.GetKeyDown(KeyCode.UpArrow)){ 
rb.AddForce(transform.up * 5f, ForceMode2D.Impulse);
}if(Input.GetKey(KeyCode.D)){ 
obj3.transform.position+=new Vector3(0.02f,0f,0f);
}if(Input.GetKeyDown(KeyCode.W)){ 
obj3.GetComponent<Rigidbody2D>().AddForce(transform.up * 5f, ForceMode2D.Impulse);
}if(Input.GetKey(KeyCode.A)){ 
obj3.transform.position-=new Vector3(0.02f,0f,0f);
}}
void OnMouseDrag (){
Vector3 mousepos=Camera.main.ScreenToWorldPoint (Input.mousePosition);
obj.transform.position=new Vector2(mousepos.x,0);
}
//cube.transform.Translate(transform.right * 0.3f * Time.deltaTime);
}

