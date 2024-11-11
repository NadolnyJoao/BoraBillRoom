using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AplicationQuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sair();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sair(){
        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
          //EditorApplication.Exit(0);
    }
}
