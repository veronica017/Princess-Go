using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class Exit : MonoBehaviour
{
    public Flowchart talkChart;
   
    void start(){
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")){
            Block target=talkChart.FindBlock("Soldier");
            talkChart.ExecuteBlock(target);
        }
    }

}