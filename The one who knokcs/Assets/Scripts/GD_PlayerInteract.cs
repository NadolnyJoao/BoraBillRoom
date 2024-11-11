using UnityEngine;
using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;

using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;




public class GD_PlayerInteract : MonoBehaviour
{
    public Camera PlayerCamera;
    public float InteractionDistance = 3f;
    public GameObject interactionText;
    public GameObject machadoObj;
    private GD_InteractObject currentInteractable;
    private Animator ani;
    void Start(){
        ani = GetComponent<Animator>();

    }

    void Update()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, InteractionDistance))
        {
            GD_InteractObject interactableObject = hit.collider.GetComponent<GD_InteractObject>();
            if (interactableObject != null && interactableObject != currentInteractable)
            {
                currentInteractable = interactableObject;
                interactionText.SetActive(true);
                TextMeshProUGUI textComponent = interactionText.GetComponent<TextMeshProUGUI>();
                
                if (textComponent != null)// so mostrar o texto/legenda quando não estiver interagindo com a porta
                {
                    textComponent.text = currentInteractable.GetInteractionText();
                }
            }
        }
        else
        {
            currentInteractable = null;
            interactionText.SetActive(false);
        }

    }

    public void UsarMachado()
    {
        if(currentInteractable.GetInteractionText() == "prota de saida")//interagindo com a porta 
        {
            Debug.Log("tentar abrir a porta");
            //verificar se tem o machado
            if(machadoObj.active)
            {
                // Animator ani = GetComponent<Animator>();
                ani.SetBool("axe", true);//laroye
                Invoke("DesligarAniMachado",1);
                Debug.Log("Ze pilitra me ajude nessa merda prf");
                /*
                Seu Zé
                Ele é mestre na aruanda
                Saravá a sua banda
                Vem chegando devagar 
                */
            }
            //iniciar a animação
        }
    }
    private void DesligarAniMachado()
    {
         //Animator ani = GetComponent<Animator>();
        ani.SetBool("axe", false);//laroye
        /*
        Quando ele chega chega sempre sorridente
        Com cigarro entre os dentes
        De branco pra amenizar
        */
    }

    public void OnInteract()
    {
        
        currentInteractable?.Interact();
        //if(currentInteractable.GetInteractionText() == "porta de sair")Destroy(currentInteractable.gameObject,2);
        //não vou testar isso com a benção de exu vai funcionar quando o joao usar;
    }


}