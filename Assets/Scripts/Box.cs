using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class Box : MonoBehaviour
{

    public static bool here;
    public Flowchart talkChart;
    static public bool hasKey = false;
    public static bool completed = false;
    public GameObject key;

    void Start(){
        if (completed)
        {
            gameObject.SetActive(false);
            key.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        here = true;
        if (!hasKey)
        {
            Block target=talkChart.FindBlock("AskForKey");
            talkChart.ExecuteBlock(target);
        }
        else 
        {
            Block target=talkChart.FindBlock("Congratulations");
            talkChart.ExecuteBlock(target);
            completed = true;
            gameObject.SetActive(false);
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