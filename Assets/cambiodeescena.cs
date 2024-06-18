using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiodeescena : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Cambiarescena(string nombreescena)
    {
        SceneManager.LoadScene(nombreescena);
    }
}
