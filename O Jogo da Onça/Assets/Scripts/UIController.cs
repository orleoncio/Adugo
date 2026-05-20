using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    
    public Text mensagemNaTela;
    public GameObject botaoDeRegras;
    public GameObject livroDeRegras;
    public GameObject backDialogue;
    public GameObject textoDoDialogo;
    public GameObject textoDoNome;

    //Variaveis para o dialogo
    public float typeDelay;
    public TextMeshProUGUI textObject;
    public TextMeshProUGUI nome;

    public DialogueData dialogos;
    public bool podePassarTexto;
    public int contadorDeTexto;

    public int ordemDialogo;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        ProximoTexto();
    }

    public void MensagemPraSentar(bool enabled)
    {
        if(enabled)
        {
            mensagemNaTela.text = "Aperte E para Sentar";
        }
        else
        {
            mensagemNaTela.text = "";
        }
    }

    IEnumerator TypeText()
    {
        if (contadorDeTexto < dialogos.talkScript.Count)
        {
            nome.text = dialogos.talkScript[contadorDeTexto].name;
            textObject.text = dialogos.talkScript[contadorDeTexto].text;
            textObject.maxVisibleCharacters = 0;
            for (int c = -10; c <= textObject.text.Length; c++)
            {
                textObject.maxVisibleCharacters = c;
                yield return new WaitForSeconds(typeDelay);
                if (c == textObject.text.Length)
                {
                    podePassarTexto = true;
                }
                else
                {
                    podePassarTexto = false;
                }
            }
        }

        if (contadorDeTexto == 5)
        {
            botaoDeRegras.SetActive(true);
        }

        if (contadorDeTexto == dialogos.talkScript.Count)
        {
            GameController.instance.StartCoroutine("IniciaJogo");
            backDialogue.SetActive(false);
            textoDoDialogo.SetActive(false);
            textoDoNome.SetActive(false);
            podePassarTexto = false;
            contadorDeTexto = 0;
            GameController.instance.typeTextFoiLido = true;
        }

    }

    IEnumerator DialogoPosMorte()
    {
        if (contadorDeTexto < dialogos.talkScript2.Count)
        {
            nome.text = dialogos.talkScript2[contadorDeTexto].name;
            textObject.text = dialogos.talkScript2[contadorDeTexto].text;
            textObject.maxVisibleCharacters = 0;
            for (int c = -10; c <= textObject.text.Length; c++)
            {
                textObject.maxVisibleCharacters = c;
                yield return new WaitForSeconds(typeDelay);
                if (c == textObject.text.Length)
                {
                    podePassarTexto = true;
                }
                else
                {
                    podePassarTexto = false;
                }
            }
        }

        if(contadorDeTexto == dialogos.talkScript2.Count)
        {
            backDialogue.SetActive(false);
            textoDoDialogo.SetActive(false);
            textoDoNome.SetActive(false);
            podePassarTexto = false;
            contadorDeTexto = 0;
            GameController.instance.RestartGame1();
        }
    }

    IEnumerator DialogoPosVitoria()
    {
        if (contadorDeTexto < dialogos.talkScript3.Count)
        {
            nome.text = dialogos.talkScript3[contadorDeTexto].name;
            textObject.text = dialogos.talkScript3[contadorDeTexto].text;
            textObject.maxVisibleCharacters = 0;
            for (int c = -10; c <= textObject.text.Length; c++)
            {
                textObject.maxVisibleCharacters = c;
                yield return new WaitForSeconds(typeDelay);
                if (c == textObject.text.Length)
                {
                    podePassarTexto = true;
                }
                else
                {
                    podePassarTexto = false;
                }
            }
        }

        if (contadorDeTexto == dialogos.talkScript2.Count)
        {
            backDialogue.SetActive(false);
            textoDoDialogo.SetActive(false);
            textoDoNome.SetActive(false);
            podePassarTexto = false;
            contadorDeTexto = 0;
        }
    }

    void ProximoTexto()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0) && podePassarTexto)
        {
            if(textObject.text == dialogos.talkScript[contadorDeTexto].text)
            {
                contadorDeTexto++;
                StartCoroutine("TypeText");
            }

            if (textObject.text == dialogos.talkScript2[contadorDeTexto].text)
            {
                contadorDeTexto++;
                StartCoroutine("DialogoPosMorte");
            }

            if (textObject.text == dialogos.talkScript3[contadorDeTexto].text)
            {
                contadorDeTexto++;
                StartCoroutine("DialogoPosVitoria");
            }
        }
    }

    IEnumerator InicioDoDialogo()
    {
        yield return new WaitForSeconds(1f);
        backDialogue.SetActive(true);
        textoDoDialogo.SetActive(true);
        textoDoNome.SetActive(true);
        StartCoroutine("TypeText");
    }

    IEnumerator InicioDialogoPosMorte()
    {
        yield return new WaitForSeconds(1f);
        backDialogue.SetActive(true);
        textoDoDialogo.SetActive(true);
        textoDoNome.SetActive(true);
        StartCoroutine("DialogoPosMorte");
    }

    IEnumerator InicioDialogoPosVitoria()
    {
        yield return new WaitForSeconds(1f);
        backDialogue.SetActive(true);
        textoDoDialogo.SetActive(true);
        textoDoNome.SetActive(true);
        StartCoroutine("DialogoPosVitoria");
    }

    
}
