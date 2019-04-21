using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUsing : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }

    // Update is called once per frame
    public void Use()
    {
        Box.hasKey = true;
        Debug.Log("key is used");
        Destroy(gameObject);
    }
}
