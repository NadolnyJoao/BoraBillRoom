using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machado : MonoBehaviour
{
   
    public PaintsChalange activate;
    public GameObject Axe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ActivateAxe();
    }

    public void ActivateAxe(){
         if (activate.TudoCerto){
            Axe.SetActive(true);
        }


    }


}
