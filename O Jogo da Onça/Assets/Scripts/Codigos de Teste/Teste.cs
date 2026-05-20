using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public int[] meuArray;

    // Start is called before the first frame update
    void Start()
    {
        // Criar um array com dados de exemplo
        int[] meuArray = { 1, 2, 3, 4, 5 };

        // Exibir o array original
        Debug.Log("Array Original: " + string.Join(", ", meuArray));

        // Apagar todos os dados do array atribuindo um novo array vazio
        meuArray = new int[0];

        // Exibir o array após a "limpeza"
        Debug.Log("Array Após Limpar: " + string.Join(", ", meuArray));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
