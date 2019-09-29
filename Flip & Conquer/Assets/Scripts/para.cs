using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class para : MonoBehaviour {

 
    
    public Rigidbody coin;
    public Button buton;
    Vector3 position;

    // Use this for initialization
    void Start () {

        
        
        }

    
	
	// Update is called once per frame
	void FixedUpdate () {
       
    }

    public void paraAt()
        {
        buton.enabled = false;
        
             int rastgeley = Random.Range(20, 50);

            int rotx = Random.Range(30, 50);
            int roty = Random.Range(30, 50);
            int rotz = Random.Range(30, 50);

        position.x = rotx;
        position.y = roty;
        position.z = rotz;

        coin.AddForce(0, rastgeley, 0, ForceMode.VelocityChange);
        coin.AddTorque(position);
       
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "ground")
        {
            buton.enabled = true;
        }
    }

    }

