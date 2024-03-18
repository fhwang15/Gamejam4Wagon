using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class EndPoint : MonoBehaviour
{


    public List<GameObject> endGame = new List<GameObject>();

    public int EndScore;

    public GameObject replay;
    public GameObject Menu;


    public GameObject EndEffect;

    public TextMeshProUGUI textM;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
        EndEffect.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        textM.text = EndScore.ToString();

        if (EndScore >= 12)
        {

            for(int i = 0; i < endGame.Count; i++)
            {
                endGame[i].SetActive(false);
            }

            Menu.SetActive(true);
            EndEffect.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            EndScore++;
        }
    }
}
