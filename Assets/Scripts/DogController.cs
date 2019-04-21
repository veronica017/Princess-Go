using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class DogController : MonoBehaviour
{
    public Flowchart talkChart;
    static public bool hasBone;
    public static bool here;

    void Start()
    {
        if (hasBone)
        {
            gameObject.SetActive(false);
            print("false");
        }
        print("start");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        here = true;
        if (other.CompareTag("Player"))
        {
            if (!hasBone)
            {
                Block target = talkChart.FindBlock("Dog");
                talkChart.ExecuteBlock(target);
            }
            else if (hasBone)
            {
                Block target = talkChart.FindBlock("Disapear");
                talkChart.ExecuteBlock(target);
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            here = false;
        }
    }

}
