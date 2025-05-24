using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanchBall : MonoBehaviour {
    [SerializeField] GameObject Boll;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, Random.Range(950,1050), 0f));
	}
	
	
    private void OnTriggerEnter(Collider other)
    {
        {
            
            if (other.gameObject.CompareTag("Destroy"))

            {
                Destroy(Boll);
            }

        }
    }
}
