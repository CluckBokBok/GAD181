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
        void DestroyFood()
        {
            // Debug.Log("DestroyFood");
            Destroy(touched.gameObject);
        }

        if (touched.gameObject.CompareTag("GFood"))
        {
            Debug.Log("You dropped food!");
            
            DestroyFood(); // used to destroy
        }

        else if (touched.gameObject.CompareTag("Bad Timer"))
        {
            Debug.Log("You dropped Bad timer!");

            DestroyFood();
        }

        else if (touched.gameObject.CompareTag("Good Timer"))
        {
            Debug.Log("You dropped Good timer!");

            DestroyFood();
        }
    }
}
