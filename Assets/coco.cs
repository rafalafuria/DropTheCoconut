using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coco : MonoBehaviour
{
    public GameObject playerController;
    float countCoco;
    Rigidbody gravidade;
    // Start is called before the first frame update

    void Start()

    {
        gravidade = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()

    {

    }

    
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "pedra")

        {
            gravidade.useGravity = true;
            countCoco = playerController.GetComponent<player>().qtdcoco += 1;
        }

    }

}
