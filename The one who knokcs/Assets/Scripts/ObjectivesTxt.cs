using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectivesTxt : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ObjectivesTxts;
    public GameObject Book;
    public GameObject Lighet;
    public GameObject esqueiroTxt;
    private PaintsChalange pinturas;
    public GameObject axe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Book){
        ObjectivesTxts.text = "Voce acordou em uma sala estranha, apenas com um livro na sua frente. Leia o Livro";}
        else if (Lighet.active){
        ObjectivesTxts.text = "O livro desaparece como magica, e um esqueiro aparece na sua frente. Tem velas apagadas por todo o quarto, o esqueiro pode ajudar.";
        }
        else if(esqueiroTxt.active){
        ObjectivesTxts.text = "Tente Acender as velas";
        }
        else if(esqueiroTxt.active==false){
            ObjectivesTxts.text = "Uma sala se abriu, e nela, tem pinturas estranhas, talvez interagir com elas seja bom";
        }
        if(pinturas.TudoCerto == true){
            ObjectivesTxts.text = "A a porta se abriu de novo, e agora na mesa, tem um machado, melhor pegar ele";
        }
        else if (axe.activeInHierarchy){
            ObjectivesTxts.text = "agora tem uma chance de escapar, talvez eu possa quebrar uma porta com esse machado";

        }
    }
}
