using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorKeyUsing : MonoBehaviour
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
        if (Exit.here)
        {
            Exit.keyFound = true;
            Debug.Log("main door key is used");
            Destroy(gameObject);
        }
    }
}
