using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroyable")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Hit!");
        }
    }

}
