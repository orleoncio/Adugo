using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casa : MonoBehaviour
{
    public static Casa selectedCasa;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        selectedCasa = this;
               
        if (GameController.instance.casaSelecionada == "Caçador1")
        {
            Cacador1.instance.targetPosition = transform.position;
            Cacador1.instance.speed = 30;
            Cacador1.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 1;
            if(transform.position.x != GameController.instance.pieces[1].transform.position.x 
                || transform.position.z != GameController.instance.pieces[1].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador2")
        {
            Cacador2.instance.targetPosition = transform.position;
            Cacador2.instance.speed = 30;
            Cacador2.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 2;
            if (transform.position.x != GameController.instance.pieces[2].transform.position.x
                || transform.position.z != GameController.instance.pieces[2].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador3")
        {
            Cacador3.instance.targetPosition = transform.position;
            Cacador3.instance.speed = 30;
            Cacador3.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 3;
            if (transform.position.x != GameController.instance.pieces[3].transform.position.x
                || transform.position.z != GameController.instance.pieces[3].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador4")
        {
            Cacador4.instance.targetPosition = transform.position;
            Cacador4.instance.speed = 30;
            Cacador4.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 4;
            if (transform.position.x != GameController.instance.pieces[4].transform.position.x
                || transform.position.z != GameController.instance.pieces[4].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador5")
        {
            Cacador5.instance.targetPosition = transform.position;
            Cacador5.instance.speed = 30;
            Cacador5.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 5;
            if (transform.position.x != GameController.instance.pieces[5].transform.position.x
                || transform.position.z != GameController.instance.pieces[5].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador6")
        {
            Cacador6.instance.targetPosition = transform.position;
            Cacador6.instance.speed = 30;
            Cacador6.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 6;
            if (transform.position.x != GameController.instance.pieces[6].transform.position.x
                || transform.position.z != GameController.instance.pieces[6].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador7")
        {
            Cacador7.instance.targetPosition = transform.position;
            Cacador7.instance.speed = 30;
            Cacador7.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 7;
            if (transform.position.x != GameController.instance.pieces[7].transform.position.x
                || transform.position.z != GameController.instance.pieces[7].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador8")
        {
            Cacador8.instance.targetPosition = transform.position;
            Cacador8.instance.speed = 30;
            Cacador8.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 8;
            if (transform.position.x != GameController.instance.pieces[8].transform.position.x
                || transform.position.z != GameController.instance.pieces[8].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador9")
        {
            Cacador9.instance.targetPosition = transform.position;
            Cacador9.instance.speed = 30;
            Cacador9.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 9;
            if (transform.position.x != GameController.instance.pieces[9].transform.position.x
                || transform.position.z != GameController.instance.pieces[9].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador10")
        {
            Cacador10.instance.targetPosition = transform.position;
            Cacador10.instance.speed = 30;
            Cacador10.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 10;
            if (transform.position.x != GameController.instance.pieces[10].transform.position.x
                || transform.position.z != GameController.instance.pieces[10].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador11")
        {
            Cacador11.instance.targetPosition = transform.position;
            Cacador11.instance.speed = 30;
            Cacador11.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 11;
            if (transform.position.x != GameController.instance.pieces[11].transform.position.x
                || transform.position.z != GameController.instance.pieces[11].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador12")
        {
            Cacador12.instance.targetPosition = transform.position;
            Cacador12.instance.speed = 30;
            Cacador12.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 12;
            if (transform.position.x != GameController.instance.pieces[12].transform.position.x
                || transform.position.z != GameController.instance.pieces[12].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador13")
        {
            Cacador13.instance.targetPosition = transform.position;
            Cacador13.instance.speed = 30;
            Cacador13.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 13;
            if (transform.position.x != GameController.instance.pieces[13].transform.position.x
                || transform.position.z != GameController.instance.pieces[13].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
        
        if (GameController.instance.casaSelecionada == "Caçador14")
        {
            Cacador14.instance.targetPosition = transform.position;
            Cacador14.instance.speed = 30;
            Cacador14.instance.RotacaoDePeca();
            PiecesPosition.instance.casaSelect = false;
            GameController.instance.selectedPiece = false;
            Onca.instance.casaSelect = transform.position;
            Onca.instance.pecaSelectIndex = 14;
            if (transform.position.x != GameController.instance.pieces[14].transform.position.x
                || transform.position.z != GameController.instance.pieces[14].transform.position.z)
            {
                GameController.instance.proximaRodada();
            }
        }
    }
}
