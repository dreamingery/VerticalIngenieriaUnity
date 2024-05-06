using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloIngenieria : MonoBehaviour
{
    [SerializeField]
    GameObject modelo, rotatingArrows;
    // Start is called before the first frame update
    void Start()
    {
        modelo.gameObject.SetActive(false);
        rotatingArrows.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Modelo()
    {
        modelo.gameObject.SetActive(true);
      //  rotatingArrows.gameObject.SetActive(false);
    }
}
