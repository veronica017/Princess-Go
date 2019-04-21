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
    public BoneUsing bu;
    private bool deleteBone;
   
    void Start(){
        //x=0;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        deleteBone = false;
    }

    private void Update()
    {
        if (deleteBone)
        {
            bu.UseBone();
            deleteBone = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")){
            if(!inventory.existBone())
            {
                Block target=talkChart.FindBlock("Dog");
                talkChart.ExecuteBlock(target);
                //x++;
            }
            else{
                Block target=talkChart.FindBlock("Disapear");
                talkChart.ExecuteBlock(target);
                //bu.UseBone();
                deleteBone = true;
                //x++;
            }
            
        }
    }

}