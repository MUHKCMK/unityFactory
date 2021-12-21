using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject portal;

    private BoxCollider[] col;
    private GameObject[] destroy;

    private void Awake()
    {
        destroy = GameObject.FindGameObjectsWithTag("destructible");

        foreach (GameObject element in destroy)
        {
            if (element.GetComponent<BoxCollider>() == true)
            {
                element.GetComponent<BoxCollider>().isTrigger = true;
            }
        }
    }

}
