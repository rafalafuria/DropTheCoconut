using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedra : MonoBehaviour
{
    public float force;
    Rigidbody fisica;
    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        fisica.AddForce(GameObject.Find("mao").transform.forward * force, ForceMode.Impulse);
    }
}

