using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    
    public bool selectedPiece;

    public string casaSelecionada;

    public int rodada;
    public int pontosOnca;
    public int vitoriaOnca;

    public bool typeTextFoiLido;
    public bool dialogoDeMorteIniciou;

    //variaveis para guaradar os GameObjects da casas e das peças sendo mais facil acessa-las
    public GameObject[] pieces;
    public GameObject[] casas;
    public GameObject player;
    public MeshRenderer playerRender;
    public CapsuleCollider playerCollider;

    //Variavel de game start que vai ser true quando for pro jogo começar
    public bool gameStart;
    public bool sentouNaMesa;

    //Variaveis para controlar as animaçoes de sentar e sair da mesa
    public bool entrandoNaMesaEsq;
    public bool entrandoNaMesaDir;
    public bool saindoDaMesaEsq;
    public bool saindoDaMesaDir;

    public bool podeMover;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        rodada = 2;
        pontosOnca = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(pontosOnca == vitoriaOnca)
        {
            gameStart = false;
            dialogoDeMorteIniciou = true;
            rodada = 2;
            UIController.instance.StartCoroutine("InicioDialogoPosMorte");
            pontosOnca = 0;
            dialogoDeMorteIniciou = true;
        }
        
        CursorController();
    }

    public void proximaRodada()
    {
        rodada++;
    }

    public void PontosOnca()
    {
        pontosOnca++;
    }

    public void CursorController()
    {
        if (sentouNaMesa)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    IEnumerator IniciaJogo()
    {
        yield return new WaitForSeconds(1f);
        rodada = 2;
        gameStart = true;
    }

    IEnumerator RestartaJogo()
    {
        yield return new WaitForSeconds(2f);
        rodada = 2;
        gameStart = true;
    }

    public void RestartGame1()
    {
        pontosOnca = 0;
        for(int i = 0; i < pieces.Length; i++)
        {
            PiecesPosition.instance.pecaComida[i] = false;
            pieces[i].SetActive(true);
        }
        
        PiecesPosition.instance.pecaComida[1] = true;
        pieces[1].SetActive(false);


        Onca.instance.targetPosition = casas[16].transform.position;
        pieces[0].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador1.instance.targetPosition = casas[3].transform.position;
        pieces[1].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador2.instance.targetPosition = casas[4].transform.position;
        pieces[2].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador3.instance.targetPosition = casas[5].transform.position;
        pieces[3].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador4.instance.targetPosition = casas[9].transform.position;
        pieces[4].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador5.instance.targetPosition = casas[10].transform.position;
        pieces[5].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador6.instance.targetPosition = casas[11].transform.position;
        pieces[6].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador7.instance.targetPosition = casas[17].transform.position;
        pieces[7].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador8.instance.targetPosition = casas[18].transform.position;
        pieces[8].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador9.instance.targetPosition = casas[22].transform.position;
        pieces[9].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador10.instance.targetPosition = casas[23].transform.position;
        pieces[10].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador11.instance.targetPosition = casas[24].transform.position;
        pieces[11].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador12.instance.targetPosition = casas[28].transform.position;
        pieces[12].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador13.instance.targetPosition = casas[29].transform.position;
        pieces[13].transform.rotation = Quaternion.Euler(0, 180, 0);
        Cacador14.instance.targetPosition = casas[30].transform.position;
        pieces[14].transform.rotation = Quaternion.Euler(0, 180, 0);

        Onca.instance.casaSelect = new Vector3(0, 0, 0);
        Onca.instance.pecaSelectIndex = 0;

        StartCoroutine("RestartaJogo");
    }
}
