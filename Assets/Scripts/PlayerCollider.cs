using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollider : MonoBehaviour
{
public Vector3 LastPos;

    // Start is called before the first frame update
    void Start()
    {
        LastPos = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillTrigger"))
        {
            transform.position = LastPos;
        }
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            LastPos = transform.position;
        }
    }
}
