using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public bool test = true;
    public bool blockking = false;
    private void Update()
    {
        


    }
    

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "KingDetect")
        {
            blockking = true;

        }

        if (other.gameObject.name != null && other.gameObject.tag != "KingDetect")
        {
            
                gameObject.GetComponent<MeshRenderer>().enabled = true;
        }

        if (GameControllet.hodWhite && GameControllet.ktovibran == 1 && blockking == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;

        }
        if (other.gameObject.transform.position.x == transform.position.x && other.gameObject.transform.position.z == transform.position.z)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }




    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name != null && other.gameObject.tag != "KingDetect")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

        if (other.gameObject.tag == "KingDetect")
        {
            blockking = false;
            
        }

    }
     
    private void OnMouseDown()
    {
       if (gameObject.GetComponent<MeshRenderer>().enabled == true)
        {
            
            GameControllet.ktovibranobj.transform.position = transform.position;
            GameControllet.hodWhite = !GameControllet.hodWhite;
            GameControllet.ktovibran = 0;
            
            

        }
         
        
    }
   
}

