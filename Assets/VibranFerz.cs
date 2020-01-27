using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibranFerz : MonoBehaviour
{
    BoxCollider[] myColliders;
    public int ktovib;
    public GameObject chil;
    
    
    private void Awake()
    {
        myColliders = gameObject.GetComponents<BoxCollider>();
        myColliders[0].size = new Vector3(0, 0, 0);
        myColliders[1].size = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (GameControllet.ktovibran == ktovib)
        {
            myColliders[0].size = new Vector3(1, 1, 30);
            myColliders[1].size = new Vector3(30, 1, 1);
        }
        else
        {
           
            myColliders[0].size = new Vector3(0, 0, 0);
            myColliders[1].size = new Vector3(0, 0, 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "White" && GameControllet.hodWhite)
        {
            chil.SetActive(true);
            
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "White")
        {
            chil.SetActive(false);

        }

    }
}
