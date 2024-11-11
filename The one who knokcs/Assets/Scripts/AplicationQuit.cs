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
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
          //EditorApplication.Exit(0);
    }
}
