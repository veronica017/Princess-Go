using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public string[] destroyedObj;
    public int numberOfDestroyedObj = 0;
    private bool bone;

    private void Start()
    {
        bone = false;
    }

    public void setExistBone()
    {
        bone = true;
    }

    public bool existBone()
    {
        return bone;
    }
}
