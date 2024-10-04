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
    private bool maxSprites;
    private int counter;
    private int currentSprite = 0;

    void Awake()
    {
        maxSprites = false;
        textoDoBalao.SetActive(false);
        pimentao.enabled = false;
        cebolaCortada.enabled = false;
        alho.enabled = false;
        analu.enabled = false;
    }

    void Update()
    {
        // Verifica se a barra de espaço foi pressionada
        if (Input.GetKeyDown(KeyCode.Space) && !maxSprites)
        {
            NextSprite();
        }

        if (maxSprites && Input.GetKeyDown(KeyCode.X))
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
                maxSprites = true; 
                return; 
            }

            if (currentSprite == 4)
            {
                instrucao.SetActive(false);
                cebolaCortada.enabled = true;
            }
            else if (currentSprite == 5)
            {
                pimentao.enabled = true;
            }
            else if (currentSprite == 7)
            {
                alho.enabled = true;
                analu.enabled = true;
                textoDoBalao.SetActive(true);
                qteManager.SetActive(false);
                maxSprites = true; 
            }

            image.sprite = spriteChoices[currentSprite];
        }
    }
}
