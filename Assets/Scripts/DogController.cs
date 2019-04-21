using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class DogController : MonoBehaviour
{
    public Flowchart talkChart;
    private int x;
    static public bool hasBone;

    void start()
    {
        x = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            if (!hasBone)
            {
                Block target = talkChart.FindBlock("Dog");
                talkChart.ExecuteBlock(target);
                x++;
            }
            else if (hasBone)
            {
                Block target = talkChart.FindBlock("Disapear");
                talkChart.ExecuteBlock(target);
                x++;
            }

        }
    }

}
