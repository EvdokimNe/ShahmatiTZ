using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllet : MonoBehaviour
{
    public Camera cameraWhite;
    public Camera cameraBlack;
    private Camera hideCamera;

    public static bool hodWhite = true;
    
    public static GameObject ktovibranobj;
    

    RaycastHit hit;
    Ray ray;

    public static GameObject[] allplane = new GameObject[64];
    public int vcego;

    public static int ktovibran = 0;

    public GameObject whitewin;
    public GameObject blackwin;
    public GameObject restart;

    public GameObject king;

    private void Awake()
    {
        
        allplane = GameObject.FindGameObjectsWithTag("Plane");
    }

    private void Start()
    {
        cameraWhite.enabled = true;
        cameraBlack.enabled = false;
        ktovibran = 0;
        hodWhite = true;

    }
    void Update()
    {
        
        if (hodWhite)
        {
           
            cameraWhite.enabled = true;
            cameraBlack.enabled = false;
            
            hideCamera = cameraWhite;
        }
           
        else
        {
            cameraWhite.enabled = false;
            cameraBlack.enabled = true;
            hideCamera = cameraBlack;
            
        }
            


        if (Input.GetMouseButtonDown(0))
        {

            ray = hideCamera.ScreenPointToRay(Input.mousePosition);
            


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Red"))
                {
                    Destroy(hit.collider.GetComponent<DestroyParrent>().parrent);
                    ktovibranobj.transform.position = hit.collider.GetComponent<DestroyParrent>().parrent.transform.position;
                    whitewin.SetActive(true);
                    restart.SetActive(true);                    
                    ktovibran = 0;
                }

                if (hit.collider.gameObject.name == "King" && hodWhite)
                {
                    
                    ktovibran = 1;
                    
                    ktovibranobj = GameObject.Find("King");
                    vcego = 0;
                    Invoke("Shet", 0.1f);
                    Invoke("Shettime", 0.15f);
                   
                        

                  

                }



                if (hit.collider.gameObject.name == "FerzBlackOne" && !hodWhite )
                {
                    ktovibran = 2;
                   
                    ktovibranobj = GameObject.Find("FerzBlackOne");                    
                }
                if (hit.collider.gameObject.name == "FerzBlackTwo" && !hodWhite)
                {
                    ktovibran = 3;
                    
                    ktovibranobj = GameObject.Find("FerzBlackTwo");
                }

            }
            


        }
    }
    void Shet()
    {
        for (int i = 0; i <= 63; i++)
        {
            if (allplane[i].GetComponent<MeshRenderer>().enabled == true)
            {
                
                vcego++;
                
                Debug.Log(vcego);
                
            }
            


        }
    }
    void Shettime()
    {
        if (vcego == 0)
        {

            Destroy(king);
            blackwin.SetActive(true);
            restart.SetActive(true);
        }
    }
}
