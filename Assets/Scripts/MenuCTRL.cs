using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCTRL : MonoBehaviour
{
    [SerializeField]
    GameObject startScreen, instruccionesScreen;

    // Start is called before the first frame update
    void Start()
    {
        startScreen.SetActive(true);
        instruccionesScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Instrucciones()
    {
        startScreen.SetActive(false);
        instruccionesScreen.SetActive(true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("LaboratorioManufactura");
    }
}
