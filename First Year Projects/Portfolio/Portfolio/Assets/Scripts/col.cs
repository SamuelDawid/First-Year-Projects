using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public GameObject FloatingText;
    
    private void OnTriggerEnter2D(Collider2D collision)
        {
        if (collision.tag == "Horse")
        {
            Control.liveLeft--;
            
            
        }
        if (collision.tag == "Horse")
        {
            FloatingText.SetActive(!FloatingText.activeSelf);
        }
       
        

        




}
   
}


