using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Onca : MonoBehaviour
{
    public static Onca instance;
    public Vector3 targetPosition;
    public float speed;

    public Vector3 casaSelect;
    public int pecaSelectIndex;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if(casaSelect == GameController.instance.pieces[pecaSelectIndex].transform.position && GameController.instance.gameStart)
        {
            if (!GameController.instance.selectedPiece && GameController.instance.rodada % 2 == 0)
            {
                targetPosition = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
                speed = 10;
                GameController.instance.selectedPiece = true;
                PiecesPosition.instance.ExecutaPosicoes();
                StartCoroutine("SpawCasas");
                GameController.instance.casaSelecionada = "Onça";
            }
        } 
    }

    private void OnMouseDown()
    {
        
    }

    IEnumerator SpawCasas()
    {
        PiecesPosition.instance.pieceSelect = transform.position;
        yield return new WaitForSeconds(0.5f);
        PiecesPosition.instance.casaSelect = true;
        OncaIA.instance.StartCoroutine("SalvaCasas");
    }

    public void RotacaoDePeca()
    {
        if (transform.position.x < targetPosition.x && transform.position.z == targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (transform.position.x > targetPosition.x && transform.position.z == targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }

        if (transform.position.x == targetPosition.x && transform.position.z < targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (transform.position.x == targetPosition.x && transform.position.z > targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (transform.position.x < targetPosition.x && transform.position.z < targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }

        if (transform.position.x < targetPosition.x && transform.position.z > targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 135, 0);
        }

        if (transform.position.x > targetPosition.x && transform.position.z > targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 225, 0);
        }

        if (transform.position.x > targetPosition.x && transform.position.z < targetPosition.z)
        {
            transform.rotation = Quaternion.Euler(0, 315, 0);
        }
    }
}
