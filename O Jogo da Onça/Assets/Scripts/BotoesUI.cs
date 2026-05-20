using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotaoDeRegras()
    {
        UIController.instance.livroDeRegras.SetActive(true);
        UIController.instance.botaoDeRegras.SetActive(false);
    }

    public void FecharLivroDeRegras()
    {
        UIController.instance.livroDeRegras.SetActive(false);
        UIController.instance.botaoDeRegras.SetActive(true);
    }

    public void ProximaCena()
    {
        SceneManager.LoadScene(1);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
