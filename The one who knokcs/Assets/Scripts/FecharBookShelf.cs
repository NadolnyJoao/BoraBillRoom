using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharBookShelf : MonoBehaviour
{
    public bool Trigger;
    public GameObject BookShelf;
    public GameObject NewBookShelf;
    public GameObject Axe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
    {
        Debug.Log("rebola");
        Trigger = true;
        BookShelf.SetActive(false);
        NewBookShelf.SetActive(true);
        Axe.SetActive(true);

    }
    /*void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "FecharBookShelf")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
        }*/

       
    }

