using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{

    // Start is called before the first frame update
    public List<Transform> locate = new List<Transform>();

    public LittleParticles littleParticles;

    public int spawncount;
    public float spawnBtwn;

    public bool pressGo;

    // Start is called before the first frame update
    void Start()
    {
        pressGo = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (pressGo)
        {
            Summoning();
            pressGo = false;

        }

    }

    void Summoning()
    {
        List<Transform> usedFallPosition = new List<Transform>();


        for (int i = 0; i < spawncount; i++)
        {
            int randomIndex = Random.Range(0, locate.Count);
            Transform fallPos = locate[randomIndex];

            while (usedFallPosition.Contains(fallPos))
            {
                randomIndex = Random.Range(0, locate.Count);
                fallPos = locate[randomIndex];
            }


            LittleParticles newthings = Instantiate(littleParticles);
            newthings.moveHandle.position = fallPos.position;

            usedFallPosition.Add(fallPos);

        }
    } 
}
