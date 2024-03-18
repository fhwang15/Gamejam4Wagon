using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");

        transform.Translate((new Vector3(x, 0) * force) * Time.deltaTime);

    }
}
