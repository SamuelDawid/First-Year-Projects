using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
    public GameObject Flar;
    
    


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boll"))
        {
            Flar.SetActive(!Flar.activeSelf);

        }
        

            
            
            

        
        
       

        
    }
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightAlt) || (Input.GetKeyUp(KeyCode.LeftAlt)))
        {
            Flar.SetActive(false);
        }
    }



}

