using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangePanSprite : MonoBehaviour
{
    public Image image;
    public Image cebolaFrita;
    public Image alhoFrito;
    public Image pimentaoFrito;
    public Image camaraoFrito;
    private bool maxSprites;
    private int counter;
    private int currentSprite = 0;
    public List<Sprite> spriteChoices;


    void Awake()
    {
        cebolaFrita.enabled = false;
        alhoFrito.enabled = false;
        pimentaoFrito.enabled = false;
        camaraoFrito.enabled = false;
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
            GoToEnding();
        }
    }

    public void GoToEnding()
    {
        SceneManager.LoadScene("Ending");
        Time.timeScale = 0f;
    }

    public void NextSprite()
    {
        counter++;
        print(counter);
        if (counter == 1)
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

            if (currentSprite == 3)
            {
                cebolaFrita.enables = true;
            }

            if (currentSprite == 6)
            {
                alhoFrito.enabled = true;
            }

            if (currentSprite == 9)
            {
                pimentaoFrito.enabled = true;
            }

            if (currentSprite == 12)
            {
                camaraoFrito.enabled = true;
            }

            else if (currentSprite == 13)
            {
                //qteManager.SetActive(false);
                maxSprites = true;
            }

            image.sprite = spriteChoices[currentSprite];
        }
    }
}
