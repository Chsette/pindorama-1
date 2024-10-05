using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePass : MonoBehaviour
{
    public GameObject firstDialogue;
    public GameObject secondDialogue;
    public GameObject thirdDialogue;
    public GameObject pressX;
    public AudioSource otherhm;
    public AudioSource slighthm;

    // Start is called before the first frame update
    void Start()
    {
        firstDialogue.SetActive(true);
        secondDialogue.SetActive(false);
        thirdDialogue.SetActive(false);
    }

    public void playTheHm()
    {
        slighthm.Play();
    }

    public void playTheOtherHm()
    {
        otherhm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se a barra de espaço foi pressionada
        if (firstDialogue && Input.GetKeyDown(KeyCode.X))
        {
            firstDialogue.SetActive(false);
            secondDialogue.SetActive(true);
            playTheHm();

            if (secondDialogue && Input.GetKeyDown(KeyCode.X))
            {
                secondDialogue.SetActive(false);
                thirdDialogue.SetActive(true);
                playTheOtherHm();
                pressX.SetActive(false);
            }

        }
    }
}
