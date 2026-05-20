using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacador13 : MonoBehaviour
{
    public static Cacador13 instance;
    public Vector3 targetPosition;
    public float speed;

    public GameObject that;

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
    }

    private void OnMouseDown()
    {
        if (!GameController.instance.selectedPiece && GameController.instance.rodada % 2 == 1)
        {
            targetPosition = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
            speed = 10;
            GameController.instance.selectedPiece = true;
            PiecesPosition.instance.ExecutaPosicoes();
            StartCoroutine("SpawCasas");
            GameController.instance.casaSelecionada = "Caçador13";
        }
    }

    IEnumerator SpawCasas()
    {
        PiecesPosition.instance.pieceSelect = transform.position;
        yield return new WaitForSeconds(0.5f);
        PiecesPosition.instance.casaSelect = true;
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

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Onça" && GameController.instance.gameStart)
        {
            StartCoroutine("PecaComida");
        }
    }

    IEnumerator PecaComida()
    {
        PiecesPosition.instance.pecaComida[13] = true;
        GameController.instance.PontosOnca();
        yield return new WaitForSeconds(0.1f);
        that.SetActive(false);
    }
}
