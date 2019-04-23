using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleUsing3 : MonoBehaviour
{
    private Transform player;
    private Inventory inventory;
    public AudioClip usingItemAudio;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    public void Use()
    {
        if (BallController.here)
        {
            BallController.ballFound[2] = true;
            AudioSource.PlayClipAtPoint(usingItemAudio, new Vector3(0, 0, 0));
            Debug.Log("marble3 is used");
            inventory.numberOfMarbles++;
            Destroy(gameObject);
        }
    }
}
