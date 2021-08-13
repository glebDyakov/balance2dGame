/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vt : MonoBehaviour
{	public int rand;
	private int x;
	Animator anima;
	public GameObject obj2;
	void Start(){
	x=1;
	rand=Random.Range(1,3);
anima=GetComponent<Animator>();
obj2=GetComponent<GameObject>();

	

    void OnMouseDown(){
	if(x==1){
print("Победа 1");
//Destroy(obj,3f);
anima.SetInteger("anim1",1);
//Instantiate(obj,transform.position.x + 5f,transform.position.y + 5f,transform.position.z,transform.rotation);
void Update(){
if (Input.GetKeyDown(KeyCode.D)){
obj2.transform.Translate(transform.up*5f);
}
if (Input.GetKeyDown(KeyCode.A)){
obj2.transform.Translate(transform.up*5f);
}
}
}
*/
