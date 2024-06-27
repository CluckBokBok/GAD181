using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFoodCatcher : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D touched)
    {
        if (touched.gameObject.CompareTag("GFood"))
        {
            Debug.Log("You dropped food!");
           
            
            DestroyFood(); // used to destroy

             void DestroyFood()
             {
                // Debug.Log("DestroyFood");
                Destroy(touched.gameObject);
             }
        }
    }


}
