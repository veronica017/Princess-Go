using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUsing : MonoBehaviour
{
    private Transform player;
    public AudioClip usingItemAudio;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }

    // Update is called once per frame
    public void Use()
    {
        if (Box.here == true)
        {
            Box.hasKey = true;
            AudioSource.PlayClipAtPoint(usingItemAudio, new Vector3(0, 0, 0));
            Debug.Log("key is used");
            Destroy(gameObject);
        }
    }
}
