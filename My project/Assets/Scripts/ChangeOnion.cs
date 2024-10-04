using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeOnion : MonoBehaviour
{
    public GameObject textoDoBalao;
    public GameObject instrucao;
    public Image image;
    public Image pimentao;
    public Image cebolaCortada;
    public Image alho;
    public Image analu;
    public GameObject qteManager;
    public List<Sprite> spriteChoices;
    private int counter;
    private int currentSprite = 0;

    void Awake()
    {
        textoDoBalao.SetActive(false);
        pimentao.enabled = false;
        cebolaCortada.enabled = false;
        alho.enabled = false;
        analu.enabled = false;
    }

    void Update()
    {
        // Verifica se a barra de espaço foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSprite();
        }

        if (currentSprite == 7 && Input.GetKeyDown(KeyCode.X))
        {
            GoToPan();
        }

    }

    public void GoToPan()
    {
        SceneManager.LoadScene("Frying Step");
        Time.timeScale = 0f;
    }

    public void NextSprite()
    {
        counter++;
        print(counter);
        if (counter == 2)
        {
            currentSprite++;
            counter = 0;
            if (currentSprite >= spriteChoices.Count)
            {
                image.enabled = false;
                Debug.Log("Sprite removida");
            }

            else if (currentSprite == 4)
            {
                cebolaCortada.enabled = true;
            }

            else if (currentSprite == 5)
            {
                pimentao.enabled = true;
            }

            else if (currentSprite == 7)
            {
                alho.enabled = true;
                instrucao.SetActive(false);
                analu.enabled = true;
                textoDoBalao.SetActive(true);
                qteManager.SetActive(false);

            }

            image.sprite = spriteChoices[currentSprite];

        }

    }

}
