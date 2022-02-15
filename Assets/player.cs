using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    public GameObject pedra;
    public GameObject mao;
    public float tps, tempo;
    public float timer = 0f;
    public float qtdcoco = 0;
    public Text cocoDropped, time;
    public bool pausa = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && tempo > 1 / tps)
        {
            atirar();
            tempo = 0;
        }
        time.text = "Tempo: " + timer.ToString("00");
        cocoDropped.text = "Cocos Caídos: " + qtdcoco;
        if (tps < 1)
            tps = 1;

        
        if (pausa == true)
        {
            tempo = tempo + Time.deltaTime;
            timer = timer + Time.deltaTime;
        }
        if (qtdcoco >= 12)
        {
            pausa = false;
        }
        

    }
    void atirar()
    {
        Instantiate(pedra, mao.transform.position, mao.transform.rotation);
    }
}
