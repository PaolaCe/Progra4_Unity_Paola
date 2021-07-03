using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardmanager : MonoBehaviour
{
    public Card card;

    public Text nombre;
    public Text atk;
    public Text hp;
    public Text costo;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nombre" + card.name);
    }

}
