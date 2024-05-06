using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject startScreen, qrScreen, modelScreen, arrows, diapo1, diapo2, lab;

    //video fondo
    [SerializeField]
    VideoPlayer videoPlayer;
    [SerializeField]
    VideoClip clipBlue, clipWhite;

    int conteoScreenActual;

    // Start is called before the first frame update
    void Start()
    {
        startScreen.gameObject.SetActive(true);
        qrScreen.gameObject.SetActive(false);
        modelScreen.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
        diapo1.gameObject.SetActive(false);
        diapo2.gameObject.SetActive(false); 
        lab.gameObject.SetActive(false);

        conteoScreenActual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("LaboratorioManufactura");

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ScreenQR()
    {
        startScreen.gameObject.SetActive(false);
        qrScreen.gameObject.SetActive(true);
        conteoScreenActual = 1;
        print(conteoScreenActual);
        videoPlayer.clip = clipWhite;

        modelScreen.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
        diapo1.gameObject.SetActive(false);
        diapo2.gameObject.SetActive(false);
        lab.gameObject.SetActive(false);
    }

    public void ModeloIngenieria()
    {
        qrScreen.gameObject.SetActive(false);
        modelScreen.gameObject.SetActive(true);
        videoPlayer.clip = clipBlue;
        arrows.gameObject.SetActive(true);
        conteoScreenActual = 2;
        print(conteoScreenActual);


        startScreen.gameObject.SetActive(false);
        diapo1.gameObject.SetActive(false);
        diapo2.gameObject.SetActive(false);
        lab.gameObject.SetActive(false);
    }

    public void Diapositiva1()
    {
        arrows.gameObject.SetActive(false);
        modelScreen.gameObject.SetActive(false);
        videoPlayer.clip = clipWhite;
        diapo1.gameObject .SetActive(true);
        conteoScreenActual = 3;
        print(conteoScreenActual);



        startScreen.gameObject.SetActive(false);
        qrScreen.gameObject.SetActive(false);
        diapo2.gameObject.SetActive(false);
        lab.gameObject.SetActive(false);
    }

    public void Diapositiva2()
    {
        videoPlayer.clip = clipBlue;
        diapo2.gameObject.SetActive(true);
        conteoScreenActual = 4;
        print(conteoScreenActual);


        startScreen.gameObject.SetActive(false);
        qrScreen.gameObject.SetActive(false);
        modelScreen.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
        diapo1.gameObject.SetActive(false);
        lab.gameObject.SetActive(false);
    }

    public void Laboratorio()
    {
        videoPlayer.clip = clipWhite;
        lab.gameObject.SetActive(true);
        conteoScreenActual = 5;
        print(conteoScreenActual);


        startScreen.gameObject.SetActive(false);
        qrScreen.gameObject.SetActive(false);
        modelScreen.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
        diapo1.gameObject.SetActive(false);
        diapo2.gameObject.SetActive(false);

    }

    public void BackBtn()
    {
        if (conteoScreenActual == 1)
        {
            startScreen.gameObject.SetActive(true);

            qrScreen.gameObject.SetActive(false);
            modelScreen.gameObject.SetActive(false);
            arrows.gameObject.SetActive(false);
            diapo1.gameObject.SetActive(false);
            diapo2.gameObject.SetActive(false);
            lab.gameObject.SetActive(false);

        }
        if (conteoScreenActual == 2) 
        {
            ScreenQR();
        }
        if (conteoScreenActual == 3)
        {
            ModeloIngenieria();
        }
        if (conteoScreenActual == 4)
        {
            Diapositiva1();
        }
        if (conteoScreenActual == 5)
        {
            Diapositiva2();
        }
        if (conteoScreenActual == 6)
        {
            Laboratorio();
        }
    }


}
