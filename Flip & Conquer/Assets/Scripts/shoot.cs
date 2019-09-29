using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public Rigidbody para;
    

    // Start is called before the first frame update

    public void paraAt()
    {
       int rastgele = Random.Range(0, 3);
        para.AddForce(rastgele, rastgele, rastgele);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
}

