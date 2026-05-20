using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform characterBody;
    public Transform characterHead;

    public float sencity;

    float rotationX = 0;

    float smoothRotX;
    public float SmoothCoefX;

    public float speedMoveAnim;
    public float speedRotAnim;

    public bool gatilhoDoTexto;

    //Variaveis de Posições para animação de Interação coma a mesa
    public Vector3 posInicialEsq;
    public Vector3 posInicialDir;
    public Vector3 posFinal;
    private Quaternion rotInicialEsq;
    private Quaternion rotInicialDir;
    private Quaternion rotFinal;

    //outras variaveis para as animações
    public int fazesAnimMesa;

    // Start is called before the first frame update
    void Start()
    {
        rotInicialEsq = Quaternion.Euler(50f, -5.26f, 0);
        rotInicialDir = Quaternion.Euler(50f, -174.74f, 0);
        rotFinal = Quaternion.Euler(54.69f, -90f, 0);
    }

    private void LateUpdate()
    {
        if(GameController.instance.podeMover)
        {
            transform.position = characterHead.position;
            transform.rotation = characterHead.rotation;
            characterBody.rotation = characterHead.rotation;
        }

        if (GameController.instance.entrandoNaMesaEsq)
        {
            if (fazesAnimMesa == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, posInicialEsq, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotInicialEsq, speedRotAnim * Time.deltaTime);
            }
            
            if(transform.position == posInicialEsq && transform.rotation == rotInicialEsq)
            {
                fazesAnimMesa = 2;
            }

            if (fazesAnimMesa == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, posFinal, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotFinal, speedRotAnim * Time.deltaTime);
            }

            if (transform.position == posFinal && transform.rotation == rotFinal)
            {
                GameController.instance.sentouNaMesa = true;
                if (!gatilhoDoTexto)
                {
                    UIController.instance.StartCoroutine("InicioDoDialogo");
                    gatilhoDoTexto = true;
                }
                
                if (GameController.instance.typeTextFoiLido && !GameController.instance.gameStart && !GameController.instance.dialogoDeMorteIniciou)
                {
                    GameController.instance.gameStart = true;
                }

            }
        }

        if (GameController.instance.entrandoNaMesaDir)
        {            
            if (fazesAnimMesa == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, posInicialDir, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotInicialDir, speedRotAnim * Time.deltaTime);
            }

            if (transform.position == posInicialDir && transform.rotation == rotInicialDir)
            {
                fazesAnimMesa = 2;
            }

            if (fazesAnimMesa == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, posFinal, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotFinal, speedRotAnim * Time.deltaTime);
            }

            if (transform.position == posFinal && transform.rotation == rotFinal)
            {
                GameController.instance.sentouNaMesa = true;
                if (!gatilhoDoTexto)
                {
                    UIController.instance.StartCoroutine("InicioDoDialogo");
                    gatilhoDoTexto = true;
                }
                
                if(GameController.instance.typeTextFoiLido && !GameController.instance.gameStart)
                {
                    GameController.instance.gameStart = true;
                }
            }
        }

        if (GameController.instance.saindoDaMesaEsq)
        {
            if (fazesAnimMesa == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, posInicialEsq, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotInicialEsq, speedRotAnim * Time.deltaTime);
            }

            if (transform.position == posInicialEsq && transform.rotation == rotInicialEsq)
            {
                fazesAnimMesa = 1;
            }

            if (fazesAnimMesa == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, characterHead.position, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, characterHead.rotation, speedRotAnim * Time.deltaTime);
            }

            if(transform.position == characterHead.position && transform.rotation == characterHead.rotation)
            {
                GameController.instance.podeMover = true;
                GameController.instance.playerRender.enabled = true;
                GameController.instance.playerCollider.enabled = true;
                GameController.instance.saindoDaMesaEsq = false;
                GameController.instance.sentouNaMesa = false;
                GameController.instance.gameStart = false;
            }
        }

        if (GameController.instance.saindoDaMesaDir)
        {
            if (fazesAnimMesa == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, posInicialDir, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotInicialDir, speedRotAnim * Time.deltaTime);
            }

            if (transform.position == posInicialDir && transform.rotation == rotInicialDir)
            {
                fazesAnimMesa = 1;
            }

            if (fazesAnimMesa == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, characterHead.position, speedMoveAnim * Time.deltaTime);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, characterHead.rotation, speedRotAnim * Time.deltaTime);
            }

            if (transform.position == characterHead.position && transform.rotation == characterHead.rotation)
            {
                GameController.instance.podeMover = true;
                GameController.instance.playerRender.enabled = true;
                GameController.instance.playerCollider.enabled = true;
                GameController.instance.saindoDaMesaDir = false;
                GameController.instance.sentouNaMesa = false;
                GameController.instance.gameStart = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera(); 
    }

    void MoveCamera()
    {
        if (GameController.instance.podeMover)
        {
            float horizontalInput = Input.GetAxisRaw("Mouse X") * sencity;
            smoothRotX = Mathf.Lerp(smoothRotX, horizontalInput, SmoothCoefX);
            rotationX += smoothRotX;
            characterBody.localEulerAngles = new Vector3(0, rotationX, 0);
            transform.eulerAngles = new Vector3(0, rotationX, 0);
        } 
    }
}
