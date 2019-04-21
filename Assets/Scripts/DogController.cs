using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class DogController: MonoBehaviour
{
    public Flowchart talkChart;
    private int x;
   
    void start(){
        x=0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")){
            if(x==0)
            {
                Block target=talkChart.FindBlock("Dog");
                talkChart.ExecuteBlock(target);
                x++;
            }
            else if(x==1){
                Block target=talkChart.FindBlock("Disapear");
                talkChart.ExecuteBlock(target);
                x++;
            }
            
        }
    }

}