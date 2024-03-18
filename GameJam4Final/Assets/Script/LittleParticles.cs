using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleParticles : MonoBehaviour
{


    public Transform moveHandle;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = moveHandle.position;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EndPoint")
        {
            Destroy(gameObject);
        }
    }
}
