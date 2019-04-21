using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPickableItem : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        for (int i = 0; i < inventory.numberOfDestroyedObj; i++)
        {
            if (inventory.destroyedObj[i] == gameObject.name)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
