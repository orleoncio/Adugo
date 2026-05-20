using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncaIA : MonoBehaviour
{
    public static OncaIA instance;
    
    public int casasAtivasParaComer;
    public int casasAtivasParaMover;
    public int[] posiveisMovimentos;
    public int[] posiveisComidas;

    public int casaEscolhida;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveOnca()
    {
        if(casasAtivasParaComer >= 1)
        {
            casaEscolhida = Random.Range(1, casasAtivasParaComer);
            Onca.instance.targetPosition = GameController.instance.casas[posiveisComidas[casaEscolhida]].transform.position;
            Onca.instance.speed = 30;
            Onca.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            GameController.instance.proximaRodada();
        }
        else 
        {
            casaEscolhida = Random.Range(1, casasAtivasParaMover);
            Onca.instance.targetPosition = GameController.instance.casas[posiveisMovimentos[casaEscolhida]].transform.position;
            Onca.instance.speed = 30;
            Onca.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            GameController.instance.proximaRodada();
        }
    }
    
    IEnumerator SalvaCasas()
    {
        casasAtivasParaComer = 0;
        casasAtivasParaMover = 0;
        yield return new WaitForSeconds(0.5f);
        for (int c = 0; c < GameController.instance.casas.Length; c++)
        {
            if (GameController.instance.casas[c].activeSelf)
            {
                if (GameController.instance.casas[c].transform.position.x - GameController.instance.pieces[0].transform.position.x < -20 
                    || GameController.instance.casas[c].transform.position.x - GameController.instance.pieces[0].transform.position.x > 20
                    || GameController.instance.casas[c].transform.position.z - GameController.instance.pieces[0].transform.position.z < -20
                    || GameController.instance.casas[c].transform.position.z - GameController.instance.pieces[0].transform.position.z > 20)
                {
                    casasAtivasParaComer++;
                    posiveisComidas[casasAtivasParaComer] = c;
                }
                else
                {
                    casasAtivasParaMover++;
                    posiveisMovimentos[casasAtivasParaMover] = c;
                }
            }
        }
        MoveOnca();
    }
}
