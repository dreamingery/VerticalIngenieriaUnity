using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabCTRL : MonoBehaviour
{




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Exit();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene(2);

        }
    }

    public void Exit() { 
        Application.Quit();
    }

}
