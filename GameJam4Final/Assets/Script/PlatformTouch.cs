using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTouch : MonoBehaviour
{

    public bool activated;

    // Start is called before the first frame update
    void Start()
    {
        activated = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "TouchEndActive")
        {
            activated = true;
        }
    }

}
