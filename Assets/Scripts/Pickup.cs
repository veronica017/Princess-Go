using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    int healthPointsToAdd = 10;
    public static bool[] hasPicked = new bool[4];
    public int index;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
       
        if (hasPicked[index])
        {
            gameObject.SetActive(false);
        }
   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("Player"))
        //{
        //    // spawn the sun button at the first available inventory slot ! 
        //    for (int i = 0; i < inventory.slots.Length; i++)
        //    {
        //        if (inventory.isFull[i] == false)
        //        { // check whether the slot is EMPTY
        //            inventory.isFull[i] = true; // makes sure that the slot is now considered FULL
        //            inventory.destroyedObj[inventory.numberOfDestroyedObj] = gameObject.name;
        //            inventory.numberOfDestroyedObj++;
        //            Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
        //            Destroy(gameObject);
        //            break;
        //        }
        //    }
        //}
        hasPicked[index] = true;
        HealthPointManager.AddHealthPoints(healthPointsToAdd);
        Destroy(gameObject);

    }
}