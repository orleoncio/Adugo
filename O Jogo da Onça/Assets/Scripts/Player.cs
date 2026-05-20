using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;

    Vector3 z;
    Vector3 x;
    Vector3 y;

    public float Speed;

    public float gravity;
    
    public bool podeSentar;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Sentar();
    }

    void Mover()
    {
        if (GameController.instance.podeMover)
        {
            float zInput = Input.GetAxisRaw("Horizontal");
            float xInput = Input.GetAxisRaw("Vertical");

            z = zInput * Speed * transform.forward;
            x = -xInput * Speed * transform.right;

            if (!controller.isGrounded)
            {
                y += gravity * Time.deltaTime * Vector3.down;
            }

            Vector3 finalVelocity = z + x + y;

            controller.Move(finalVelocity * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Cadeira")
        {
            UIController.instance.MensagemPraSentar(true);
            podeSentar = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Cadeira")
        {
            UIController.instance.MensagemPraSentar(false);
            podeSentar = false;
        }
    }

    void Sentar()
    {
        if(Input.GetKeyDown(KeyCode.E) && podeSentar && !GameController.instance.entrandoNaMesaDir && !GameController.instance.entrandoNaMesaEsq)
        {
            if(transform.position.z < 0)
            {
                GameController.instance.podeMover = false;
                GameController.instance.entrandoNaMesaEsq = true;
                GameController.instance.entrandoNaMesaDir = false;
                GameController.instance.saindoDaMesaEsq = false;
                GameController.instance.saindoDaMesaDir = false;
                GameController.instance.playerRender.enabled = false;
                GameController.instance.playerCollider.enabled = false;
                UIController.instance.MensagemPraSentar(false);
                podeSentar = false;
            }

            if (transform.position.z > 0)
            {
                GameController.instance.podeMover = false;
                GameController.instance.entrandoNaMesaEsq = false;
                GameController.instance.entrandoNaMesaDir = true;
                GameController.instance.saindoDaMesaEsq = false;
                GameController.instance.saindoDaMesaDir = false;
                GameController.instance.playerRender.enabled = false;
                GameController.instance.playerCollider.enabled = false;
                UIController.instance.MensagemPraSentar(false);
                podeSentar = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && GameController.instance.gameStart && GameController.instance.rodada % 2 == 1 && !GameController.instance.selectedPiece)
        {
            if(transform.position.z < 0)
            {
                GameController.instance.entrandoNaMesaEsq = false;
                GameController.instance.entrandoNaMesaDir = false;
                GameController.instance.saindoDaMesaEsq = true;
                GameController.instance.saindoDaMesaDir = false;
            }

            if(transform.position.z > 0)
            {
                GameController.instance.entrandoNaMesaEsq = false;
                GameController.instance.entrandoNaMesaDir = false;
                GameController.instance.saindoDaMesaEsq = false;
                GameController.instance.saindoDaMesaDir = true;
            }
        }
    }
}
