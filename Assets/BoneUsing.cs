using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneUsing : MonoBehaviour
{
    private Transform player;
    private Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    /*public void Use()
    {
        Debug.Log("bone is used");
        Destroy(gameObject);
        inventory.setExistBone(false);
    }*/
}
