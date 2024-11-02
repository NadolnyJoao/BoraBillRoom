using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;  // Biblioteca do FMOD
using FMOD.Studio;

public class ArrastarBookShelf : MonoBehaviour
{
    public VelaInteraction Vela;
    public PaintsChalange Paint;
    public FecharBookShelf trigo;
    public Transform target;
    public Transform target2;
    public float Speed;
    public GameObject ShelfSound;
    public GameObject enqueiro;
    public GameObject OTrigger;
    //public GameObject FecharBookShelf;
    // public EventReference soundEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vela.AcendeuTudo){
            OnVelaInteraction();
            ShelfSound.SetActive(true);
        }
        
        }
       
        public void OnVelaInteraction(){

        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        enqueiro.SetActive(false);
        }
       
       /* public void Sound(){
             EventInstance sound = RuntimeManager.CreateInstance(soundEvent);
             sound.start();
             sound.release();
            */}
