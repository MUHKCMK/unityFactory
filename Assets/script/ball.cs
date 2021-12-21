using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : manager
{
    private Vector3 tempos;
    private Quaternion temprot;

    public GameObject effect;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "destructible")
        {
            tempos = col.gameObject.transform.GetComponent<Renderer>().bounds.center;

            Destroy(col.gameObject);
            Instantiate(effect,tempos, temprot);
        }
    }
}
