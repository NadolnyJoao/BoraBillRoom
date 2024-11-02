using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;  // Biblioteca do FMOD
using FMOD.Studio;

public class ArrastarNewBookShelf1 : MonoBehaviour
{
    public PaintsChalange Paint;

    public Transform target;
 
    public float Speed;
    public GameObject ShelfSound;
 
   
    //public GameObject FecharBookShelf;
    // public EventReference soundEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Paint.TudoCerto){
            OnVelaInteraction();
            ShelfSound.SetActive(true);
        }
        
        }
       
        public void OnVelaInteraction(){

        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
       
        }
       
       /* public void Sound(){
             EventInstance sound = RuntimeManager.CreateInstance(soundEvent);
             sound.start();
             sound.release();
            */}
