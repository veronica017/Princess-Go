using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class Box : MonoBehaviour
{
    
   
    public Flowchart talkChart;
    
    private int touch = 0;
    //static int enterTimes=0;
    static public bool hasKey = false;
    void Start(){
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasKey)
        {
            Block target=talkChart.FindBlock("AskForKey");
            talkChart.ExecuteBlock(target);
            touch++;
        }
        else 
        {
            Block target=talkChart.FindBlock("Congratulations");
            talkChart.ExecuteBlock(target);
            touch++;

        }

    }

}