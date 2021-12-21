using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject portal;

    private static int i = 0;
    private GameObject ball;
    private Collider[] col;
    private GameObject[] destroy;

    void Start(){
        destroy = GameObject.FindGameObjectsWithTag("destructible");

        for (i = 0; i < destroy.Length; i++)
        {
            col[i] = destroy[i].GetComponent<Collider>();
            col[i].isTrigger = true;
        }

        portal.transform.localScale = new Vector3(5,5,5);
    }
}
