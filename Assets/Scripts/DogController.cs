using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class DogController: MonoBehaviour
{
    public Flowchart talkChart;
    //private int boneFound;
    private Inventory inventory;
    static public bool hasBone;
   
    void Start(){
        //x=0;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")){
            if(!hasBone)
            {
                Block target=talkChart.FindBlock("Dog");
                talkChart.ExecuteBlock(target);
                //x++;
            }
            else{
                Block target=talkChart.FindBlock("Disapear");
                talkChart.ExecuteBlock(target);
                //x++;
            }
            
        }
    }

}