using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleAgua : MonoBehaviour
{
    public GameObject rioASerDesativado;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PiecesPosition.instance.casasOcupadas[14] != 0 
            && PiecesPosition.instance.casasOcupadas[20] != 0
            && PiecesPosition.instance.casasOcupadas[26] != 0
            && PiecesPosition.instance.casasOcupadas[27] != 0
            && PiecesPosition.instance.casasOcupadas[28] != 0
            && PiecesPosition.instance.casasOcupadas[29] != 0
            && PiecesPosition.instance.casasOcupadas[30] != 0)
        {
            rioASerDesativado.SetActive(false);
        }
    }
}
