using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubejump : MonoBehaviour
{	public GameObject game;
	Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
	
    }
	void OnMouseDown(){
game.transform.Translate(Vector3.up*100f* Time.deltaTime);
//game.SetActive(false);
//rb2.AddForce(transform.up * 100f, ForceMode2D.Impulse);
}
}
