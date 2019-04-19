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
    private bool key = false;
    void start(){
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (touch==0 )
        {
            Block target=talkChart.FindBlock("AskForKey");
            talkChart.ExecuteBlock(target);
            touch++;
        }
        else if (touch==1)
        {
            Block target=talkChart.FindBlock("Congratulations");
            talkChart.ExecuteBlock(target);
            touch++;

        }

    }

}