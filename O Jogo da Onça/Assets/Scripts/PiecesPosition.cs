using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesPosition : MonoBehaviour
{
    public static PiecesPosition instance;
    
    public int[] casasOcupadas;

    public Vector3 pieceSelect;
    public bool casaSelect;

    public bool[] pecaComida;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        casaSelect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (casaSelect)
        {
            if(pieceSelect.x == GameController.instance.casas[0].transform.position.x && 
                pieceSelect.z == GameController.instance.casas[0].transform.position.z)
            {
                if(pieceSelect.x == GameController.instance.pieces[0].transform.position.x && 
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[6] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[6].SetActive(true);
                    }

                    if (casasOcupadas[12] != 0)
                    {
                        if (casasOcupadas[25] == 0)
                        {
                            GameController.instance.casas[25].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[12].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[0].SetActive(true);

                    if (casasOcupadas[6] == 0)
                    {
                        GameController.instance.casas[6].SetActive(true);
                    }

                    if (casasOcupadas[12] == 0)
                    {
                        GameController.instance.casas[12].SetActive(true);
                    }
                } 
            }

            if (pieceSelect.x == GameController.instance.casas[1].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[1].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[2] != 0)
                    {
                        if (casasOcupadas[3] == 0)
                        {
                            GameController.instance.casas[3].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[2].SetActive(true);
                    }

                    if (casasOcupadas[7] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[7].SetActive(true);
                    }

                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[1].SetActive(true);

                    if (casasOcupadas[2] == 0)
                    {
                        GameController.instance.casas[2].SetActive(true);
                    }

                    if (casasOcupadas[7] == 0)
                    {
                        GameController.instance.casas[7].SetActive(true);
                    }

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[2].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[2].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[1] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[1].SetActive(true);
                    }

                    if (casasOcupadas[3] != 0)
                    {
                        if (casasOcupadas[4] == 0)
                        {
                            GameController.instance.casas[4].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[15] == 0)
                        {
                            GameController.instance.casas[15].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[2].SetActive(true);

                    if (casasOcupadas[1] == 0)
                    {
                        GameController.instance.casas[1].SetActive(true);
                    }

                    if (casasOcupadas[3] == 0)
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[3].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[3].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[2] != 0)
                    {
                        if (casasOcupadas[1] == 0)
                        {
                            GameController.instance.casas[1].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[2].SetActive(true);
                    }

                    if (casasOcupadas[4] != 0)
                    {
                        if (casasOcupadas[5] == 0)
                        {
                            GameController.instance.casas[5].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[4].SetActive(true);
                    }

                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[9] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[18] == 0)
                        {
                            GameController.instance.casas[18].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[3].SetActive(true);

                    if (casasOcupadas[2] == 0)
                    {
                        GameController.instance.casas[2].SetActive(true);
                    }

                    if (casasOcupadas[4] == 0)
                    {
                        GameController.instance.casas[4].SetActive(true);
                    }

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[9] == 0)
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[4].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[4].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[3] != 0)
                    {
                        if (casasOcupadas[2] == 0)
                        {
                            GameController.instance.casas[2].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[5] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[5].SetActive(true);
                    }

                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[17] == 0)
                        {
                            GameController.instance.casas[17].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[4].SetActive(true);

                    if (casasOcupadas[3] == 0)
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[5] == 0)
                    {
                        GameController.instance.casas[5].SetActive(true);
                    }

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[5].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[5].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[4] != 0)
                    {
                        if (casasOcupadas[3] == 0)
                        {
                            GameController.instance.casas[3].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[4].SetActive(true);
                    }

                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[11] != 0)
                    {
                        if (casasOcupadas[18] == 0)
                        {
                            GameController.instance.casas[18].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[11].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[5].SetActive(true);

                    if (casasOcupadas[4] == 0)
                    {
                        GameController.instance.casas[4].SetActive(true);
                    }

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[11] == 0)
                    {
                        GameController.instance.casas[11].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[6].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[6].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[0] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[0].SetActive(true);
                    }

                    if (casasOcupadas[13] != 0)
                    {
                        if (casasOcupadas[19] == 0)
                        {
                            GameController.instance.casas[19].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[21] == 0)
                        {
                            GameController.instance.casas[21].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[6].SetActive(true);

                    if (casasOcupadas[0] == 0)
                    {
                        GameController.instance.casas[0].SetActive(true);
                    }

                    if (casasOcupadas[13] == 0)
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[7].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[7].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[1] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[1].SetActive(true);
                    }

                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[9] == 0)
                        {
                            GameController.instance.casas[9].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[20] == 0)
                        {
                            GameController.instance.casas[20].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[7].SetActive(true);

                    if (casasOcupadas[1] == 0)
                    {
                        GameController.instance.casas[1].SetActive(true);
                    }

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[8].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[8].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[1] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[1].SetActive(true);
                    }

                    if (casasOcupadas[2] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[2].SetActive(true);
                    }

                    if (casasOcupadas[3] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[7] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[7].SetActive(true);
                    }

                    if (casasOcupadas[9] != 0)
                    {
                        if (casasOcupadas[10] == 0)
                        {
                            GameController.instance.casas[10].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[19] == 0)
                        {
                            GameController.instance.casas[19].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[15] != 0)
                    {
                        if (casasOcupadas[21] == 0)
                        {
                            GameController.instance.casas[21].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[23] == 0)
                        {
                            GameController.instance.casas[23].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[8].SetActive(true);

                    if (casasOcupadas[1] == 0)
                    {
                        GameController.instance.casas[1].SetActive(true);
                    }

                    if (casasOcupadas[2] == 0)
                    {
                        GameController.instance.casas[2].SetActive(true);
                    }

                    if (casasOcupadas[3] == 0)
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[7] == 0)
                    {
                        GameController.instance.casas[7].SetActive(true);
                    }

                    if (casasOcupadas[9] == 0)
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[15] == 0)
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[9].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[9].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[3] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[7] == 0)
                        {
                            GameController.instance.casas[7].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[11] == 0)
                        {
                            GameController.instance.casas[11].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[22] == 0)
                        {
                            GameController.instance.casas[22].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[9].SetActive(true);

                    if (casasOcupadas[3] == 0)
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[10].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[10].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[3] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[4] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[4].SetActive(true);
                    }

                    if (casasOcupadas[5] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[5].SetActive(true);
                    }

                    if (casasOcupadas[9] != 0)
                    {
                        if (casasOcupadas[8] == 0)
                        {
                            GameController.instance.casas[8].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[11] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[11].SetActive(true);
                    }

                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[21] == 0)
                        {
                            GameController.instance.casas[21].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[17] != 0)
                    {
                        if (casasOcupadas[23] == 0)
                        {
                            GameController.instance.casas[23].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[18] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[10].SetActive(true);

                    if (casasOcupadas[3] == 0)
                    {
                        GameController.instance.casas[3].SetActive(true);
                    }

                    if (casasOcupadas[4] == 0)
                    {
                        GameController.instance.casas[4].SetActive(true);
                    }

                    if (casasOcupadas[5] == 0)
                    {
                        GameController.instance.casas[5].SetActive(true);
                    }

                    if (casasOcupadas[9] == 0)
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[11] == 0)
                    {
                        GameController.instance.casas[11].SetActive(true);
                    }

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[17] == 0)
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[18] == 0)
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[11].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[11].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[5] != 0)
                    {
                        
                    }
                    else
                    {
                        GameController.instance.casas[5].SetActive(true);
                    }

                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[9] == 0)
                        {
                            GameController.instance.casas[9].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[18] != 0)
                    {
                        if (casasOcupadas[24] == 0)
                        {
                            GameController.instance.casas[24].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[11].SetActive(true);

                    if (casasOcupadas[5] == 0)
                    {
                        GameController.instance.casas[5].SetActive(true);
                    }

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[18] == 0)
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[12].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[12].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[0] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[0].SetActive(true);
                    }

                    if (casasOcupadas[13] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[25] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[25].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[12].SetActive(true);

                    if (casasOcupadas[0] == 0)
                    {
                        GameController.instance.casas[0].SetActive(true);
                    }

                    if (casasOcupadas[13] == 0)
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[25] == 0)
                    {
                        GameController.instance.casas[25].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[13].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[13].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[6] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[6].SetActive(true);
                    }

                    if (casasOcupadas[12] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[12].SetActive(true);
                    }

                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[15] == 0)
                        {
                            GameController.instance.casas[15].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[19] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[19].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[13].SetActive(true);

                    if (casasOcupadas[6] == 0)
                    {
                        GameController.instance.casas[6].SetActive(true);
                    }

                    if (casasOcupadas[12] == 0)
                    {
                        GameController.instance.casas[12].SetActive(true);
                    }

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[19] == 0)
                    {
                        GameController.instance.casas[19].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[14].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[14].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[6] != 0)
                    {
                        if (casasOcupadas[0] == 0)
                        {
                            GameController.instance.casas[0].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[6].SetActive(true);
                    }

                    if (casasOcupadas[7] != 0)
                    {
                        if (casasOcupadas[1] == 0)
                        {
                            GameController.instance.casas[1].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[7].SetActive(true);
                    }

                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[3] == 0)
                        {
                            GameController.instance.casas[3].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[13] != 0)
                    {
                        if (casasOcupadas[12] == 0)
                        {
                            GameController.instance.casas[12].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[15] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[19] != 0)
                    {
                        if (casasOcupadas[25] == 0)
                        {
                            GameController.instance.casas[25].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[19].SetActive(true);
                    }

                    if (casasOcupadas[20] != 0)
                    {
                        if (casasOcupadas[26] == 0)
                        {
                            GameController.instance.casas[26].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[20].SetActive(true);
                    }

                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[28] == 0)
                        {
                            GameController.instance.casas[28].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[14].SetActive(true);

                    if (casasOcupadas[6] == 0)
                    {
                        GameController.instance.casas[6].SetActive(true);
                    }

                    if (casasOcupadas[7] == 0)
                    {
                        GameController.instance.casas[7].SetActive(true);
                    }

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[13] == 0)
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[15] == 0)
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[19] == 0)
                    {
                        GameController.instance.casas[19].SetActive(true);
                    }

                    if (casasOcupadas[20] == 0)
                    {
                        GameController.instance.casas[20].SetActive(true);
                    }

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[15].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[15].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[2] == 0)
                        {
                            GameController.instance.casas[2].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[13] == 0)
                        {
                            GameController.instance.casas[13].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[17] == 0)
                        {
                            GameController.instance.casas[17].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[27] == 0)
                        {
                            GameController.instance.casas[27].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[15].SetActive(true);

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[16].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[16].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[8] != 0)
                    {
                        if (casasOcupadas[1] == 0)
                        {
                            GameController.instance.casas[1].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[9] != 0)
                    {
                        if (casasOcupadas[3] == 0)
                        {
                            GameController.instance.casas[3].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[5] == 0)
                        {
                            GameController.instance.casas[5].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[15] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[17] != 0)
                    {
                        if (casasOcupadas[18] == 0)
                        {
                            GameController.instance.casas[18].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[26] == 0)
                        {
                            GameController.instance.casas[26].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[22] != 0)
                    {
                        if (casasOcupadas[28] == 0)
                        {
                            GameController.instance.casas[28].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[30] == 0)
                        {
                            GameController.instance.casas[30].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[16].SetActive(true);

                    if (casasOcupadas[8] == 0)
                    {
                        GameController.instance.casas[8].SetActive(true);
                    }

                    if (casasOcupadas[9] == 0)
                    {
                        GameController.instance.casas[9].SetActive(true);
                    }

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[15] == 0)
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[17] == 0)
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[22] == 0)
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[17].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[17].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[4] == 0)
                        {
                            GameController.instance.casas[4].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[15] == 0)
                        {
                            GameController.instance.casas[15].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[18] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }

                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[29] == 0)
                        {
                            GameController.instance.casas[29].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[17].SetActive(true);

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[18] == 0)
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[18].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[18].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[10] != 0)
                    {
                        if (casasOcupadas[3] == 0)
                        {
                            GameController.instance.casas[3].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[11] != 0)
                    {
                        if (casasOcupadas[5] == 0)
                        {
                            GameController.instance.casas[5].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[11].SetActive(true);
                    }

                    if (casasOcupadas[17] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[28] == 0)
                        {
                            GameController.instance.casas[28].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[24] != 0)
                    {
                        if (casasOcupadas[30] == 0)
                        {
                            GameController.instance.casas[30].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[24].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[18].SetActive(true);

                    if (casasOcupadas[10] == 0)
                    {
                        GameController.instance.casas[10].SetActive(true);
                    }

                    if (casasOcupadas[11] == 0)
                    {
                        GameController.instance.casas[11].SetActive(true);
                    }

                    if (casasOcupadas[17] == 0)
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[24] == 0)
                    {
                        GameController.instance.casas[24].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[19].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[19].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[13] != 0)
                    {
                        if (casasOcupadas[6] == 0)
                        {
                            GameController.instance.casas[6].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[8] == 0)
                        {
                            GameController.instance.casas[8].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[25] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[25].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[19].SetActive(true);

                    if (casasOcupadas[13] == 0)
                    {
                        GameController.instance.casas[13].SetActive(true);
                    }

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[25] == 0)
                    {
                        GameController.instance.casas[25].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[20].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[20].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[7] == 0)
                        {
                            GameController.instance.casas[7].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[22] == 0)
                        {
                            GameController.instance.casas[22].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[26] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[26].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[20].SetActive(true);

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[26] == 0)
                    {
                        GameController.instance.casas[26].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[21].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[21].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[14] != 0)
                    {
                        if (casasOcupadas[6] == 0)
                        {
                            GameController.instance.casas[6].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[15] != 0)
                    {
                        if (casasOcupadas[8] == 0)
                        {
                            GameController.instance.casas[8].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[10] == 0)
                        {
                            GameController.instance.casas[10].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[20] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[20].SetActive(true);
                    }

                    if (casasOcupadas[22] != 0)
                    {
                        if (casasOcupadas[23] == 0)
                        {
                            GameController.instance.casas[23].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[26] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[26].SetActive(true);
                    }

                    if (casasOcupadas[27] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[27].SetActive(true);
                    }

                    if (casasOcupadas[28] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[21].SetActive(true);

                    if (casasOcupadas[14] == 0)
                    {
                        GameController.instance.casas[14].SetActive(true);
                    }

                    if (casasOcupadas[15] == 0)
                    {
                        GameController.instance.casas[15].SetActive(true);
                    }

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[20] == 0)
                    {
                        GameController.instance.casas[20].SetActive(true);
                    }

                    if (casasOcupadas[22] == 0)
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[26] == 0)
                    {
                        GameController.instance.casas[26].SetActive(true);
                    }

                    if (casasOcupadas[27] == 0)
                    {
                        GameController.instance.casas[27].SetActive(true);
                    }

                    if (casasOcupadas[28] == 0)
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[22].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[22].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[9] == 0)
                        {
                            GameController.instance.casas[9].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[20] == 0)
                        {
                            GameController.instance.casas[20].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[24] == 0)
                        {
                            GameController.instance.casas[24].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[28] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[22].SetActive(true);

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[28] == 0)
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[23].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[23].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[16] != 0)
                    {
                        if (casasOcupadas[8] == 0)
                        {
                            GameController.instance.casas[8].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[17] != 0)
                    {
                        if (casasOcupadas[10] == 0)
                        {
                            GameController.instance.casas[10].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[18] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }

                    if (casasOcupadas[22] != 0)
                    {
                        if (casasOcupadas[21] == 0)
                        {
                            GameController.instance.casas[21].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[24] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[24].SetActive(true);
                    }

                    if (casasOcupadas[28] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }

                    if (casasOcupadas[29] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[29].SetActive(true);
                    }

                    if (casasOcupadas[30] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[30].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[23].SetActive(true);

                    if (casasOcupadas[16] == 0)
                    {
                        GameController.instance.casas[16].SetActive(true);
                    }

                    if (casasOcupadas[17] == 0)
                    {
                        GameController.instance.casas[17].SetActive(true);
                    }

                    if (casasOcupadas[18] == 0)
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }

                    if (casasOcupadas[22] == 0)
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[24] == 0)
                    {
                        GameController.instance.casas[24].SetActive(true);
                    }

                    if (casasOcupadas[28] == 0)
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }

                    if (casasOcupadas[29] == 0)
                    {
                        GameController.instance.casas[29].SetActive(true);
                    }

                    if (casasOcupadas[30] == 0)
                    {
                        GameController.instance.casas[30].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[24].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[24].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[18] != 0)
                    {
                        if (casasOcupadas[11] == 0)
                        {
                            GameController.instance.casas[11].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }

                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[22] == 0)
                        {
                            GameController.instance.casas[22].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[30] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[30].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[24].SetActive(true);

                    if (casasOcupadas[18] == 0)
                    {
                        GameController.instance.casas[18].SetActive(true);
                    }

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[30] == 0)
                    {
                        GameController.instance.casas[30].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[25].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[25].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[12] != 0)
                    {
                        if (casasOcupadas[0] == 0)
                        {
                            GameController.instance.casas[0].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[12].SetActive(true);
                    }

                    if (casasOcupadas[19] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[19].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[25].SetActive(true);

                    if (casasOcupadas[12] == 0)
                    {
                        GameController.instance.casas[12].SetActive(true);
                    }

                    if (casasOcupadas[19] == 0)
                    {
                        GameController.instance.casas[19].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[26].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[26].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[20] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[20].SetActive(true);
                    }

                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[27] != 0)
                    {
                        if (casasOcupadas[28] == 0)
                        {
                            GameController.instance.casas[28].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[27].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[26].SetActive(true);

                    if (casasOcupadas[20] == 0)
                    {
                        GameController.instance.casas[20].SetActive(true);
                    }

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[27] == 0)
                    {
                        GameController.instance.casas[27].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[27].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[27].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[15] == 0)
                        {
                            GameController.instance.casas[15].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[26] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[26].SetActive(true);
                    }

                    if (casasOcupadas[28] != 0)
                    {
                        if (casasOcupadas[29] == 0)
                        {
                            GameController.instance.casas[29].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[27].SetActive(true);

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[26] == 0)
                    {
                        GameController.instance.casas[26].SetActive(true);
                    }

                    if (casasOcupadas[28] == 0)
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[28].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[28].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[21] != 0)
                    {
                        if (casasOcupadas[14] == 0)
                        {
                            GameController.instance.casas[14].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[22] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[18] == 0)
                        {
                            GameController.instance.casas[18].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[27] != 0)
                    {
                        if (casasOcupadas[26] == 0)
                        {
                            GameController.instance.casas[26].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[27].SetActive(true);
                    }

                    if (casasOcupadas[29] != 0)
                    {
                        if (casasOcupadas[30] == 0)
                        {
                            GameController.instance.casas[30].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[29].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[28].SetActive(true);

                    if (casasOcupadas[21] == 0)
                    {
                        GameController.instance.casas[21].SetActive(true);
                    }

                    if (casasOcupadas[22] == 0)
                    {
                        GameController.instance.casas[22].SetActive(true);
                    }

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[27] == 0)
                    {
                        GameController.instance.casas[27].SetActive(true);
                    }

                    if (casasOcupadas[29] == 0)
                    {
                        GameController.instance.casas[29].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[29].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[29].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[17] == 0)
                        {
                            GameController.instance.casas[17].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[28] != 0)
                    {
                        if (casasOcupadas[27] == 0)
                        {
                            GameController.instance.casas[27].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }

                    if (casasOcupadas[30] != 0)
                    {

                    }
                    else
                    {
                        GameController.instance.casas[30].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[29].SetActive(true);

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[28] == 0)
                    {
                        GameController.instance.casas[28].SetActive(true);
                    }

                    if (casasOcupadas[30] == 0)
                    {
                        GameController.instance.casas[30].SetActive(true);
                    }
                }
            }

            if (pieceSelect.x == GameController.instance.casas[30].transform.position.x &&
                pieceSelect.z == GameController.instance.casas[30].transform.position.z)
            {
                if (pieceSelect.x == GameController.instance.pieces[0].transform.position.x &&
                    pieceSelect.z == GameController.instance.pieces[0].transform.position.z)
                {
                    if (casasOcupadas[23] != 0)
                    {
                        if (casasOcupadas[16] == 0)
                        {
                            GameController.instance.casas[16].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[24] != 0)
                    {
                        if (casasOcupadas[18] == 0)
                        {
                            GameController.instance.casas[18].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[24].SetActive(true);
                    }

                    if (casasOcupadas[29] != 0)
                    {
                        if (casasOcupadas[28] == 0)
                        {
                            GameController.instance.casas[28].SetActive(true);
                        }
                    }
                    else
                    {
                        GameController.instance.casas[29].SetActive(true);
                    }
                }
                else
                {
                    GameController.instance.casas[30].SetActive(true);

                    if (casasOcupadas[23] == 0)
                    {
                        GameController.instance.casas[23].SetActive(true);
                    }

                    if (casasOcupadas[24] == 0)
                    {
                        GameController.instance.casas[24].SetActive(true);
                    }

                    if (casasOcupadas[29] == 0)
                    {
                        GameController.instance.casas[29].SetActive(true);
                    }
                }
            }
        }
        else
        {
            for(int i = 0; i < GameController.instance.casas.Length; i++)
            {
                GameController.instance.casas[i].SetActive(false);
            }
        }

        if(casaSelect == true 
            && GameController.instance.casas[0].activeSelf == false 
            && GameController.instance.casas[1].activeSelf == false
            && GameController.instance.casas[2].activeSelf == false
            && GameController.instance.casas[3].activeSelf == false
            && GameController.instance.casas[4].activeSelf == false
            && GameController.instance.casas[5].activeSelf == false
            && GameController.instance.casas[6].activeSelf == false
            && GameController.instance.casas[7].activeSelf == false
            && GameController.instance.casas[8].activeSelf == false
            && GameController.instance.casas[9].activeSelf == false
            && GameController.instance.casas[10].activeSelf == false
            && GameController.instance.casas[11].activeSelf == false
            && GameController.instance.casas[12].activeSelf == false
            && GameController.instance.casas[13].activeSelf == false
            && GameController.instance.casas[14].activeSelf == false
            && GameController.instance.casas[15].activeSelf == false
            && GameController.instance.casas[16].activeSelf == false
            && GameController.instance.casas[17].activeSelf == false
            && GameController.instance.casas[18].activeSelf == false
            && GameController.instance.casas[19].activeSelf == false
            && GameController.instance.casas[20].activeSelf == false
            && GameController.instance.casas[21].activeSelf == false
            && GameController.instance.casas[22].activeSelf == false
            && GameController.instance.casas[23].activeSelf == false
            && GameController.instance.casas[24].activeSelf == false
            && GameController.instance.casas[25].activeSelf == false
            && GameController.instance.casas[26].activeSelf == false
            && GameController.instance.casas[27].activeSelf == false
            && GameController.instance.casas[28].activeSelf == false
            && GameController.instance.casas[29].activeSelf == false
            && GameController.instance.casas[30].activeSelf == false)
        {
            GameController.instance.gameStart = false;
            GameController.instance.dialogoDeMorteIniciou = true;
            GameController.instance.rodada = 2;
            UIController.instance.StartCoroutine("InicioDialogoPosVitoria");
            GameController.instance.pontosOnca = 0;
            GameController.instance.dialogoDeMorteIniciou = true;
        }
    }

    public void ExecutaPosicoes()
    {
        StartCoroutine("Posicoes");
    }

    IEnumerator Posicoes()
    {
        for(int i = 0; i < casasOcupadas.Length; i++)
        {
            casasOcupadas[i] = 0;
        }
        yield return new WaitForSeconds(0.1f);
        
        for (int c = 0; c < GameController.instance.casas.Length; c++)
        {
            for (int p = 0; p < GameController.instance.pieces.Length; p++)
            {
                if (GameController.instance.pieces[p].transform.position.x == GameController.instance.casas[c].transform.position.x
                    && GameController.instance.pieces[p].transform.position.z == GameController.instance.casas[c].transform.position.z 
                     && pecaComida[p] == false)
                {
                    casasOcupadas[c] = p + 1;
                }
            }
            
        }
    }
}
