using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour
{	private GameObject o;
	public GameObject prefab;
	
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("create",5,4);
    }

    // Update is called once per frame
   void Update(){
	


        
    }
void create(){
o = Instantiate(prefab,new Vector3(Random.Range(-8,8),9f,1f), Quaternion.identity) as GameObject;
}
}
