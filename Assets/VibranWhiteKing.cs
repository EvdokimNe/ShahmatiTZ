using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibranWhiteKing : MonoBehaviour
{


    
    private void Awake()
    {
        GetComponent<BoxCollider>().size = new Vector3(0, 0, 0);
       
       

        
        
    }

    void Update()
    {
        
        if (GameControllet.ktovibran == 1)
        {
           
            GetComponent<BoxCollider>().size = new Vector3(4, 1, 4);

        }
        else
        {

            
            GetComponent<BoxCollider>().size = new Vector3(0, 0, 0);
        }
        
      
            
    }
}


    
            











