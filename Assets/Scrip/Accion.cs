using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]

public class Accion : MonoBehaviour
{

    public string nombre;
    public bool estatico;
    public bool objetivoEsel;

    public string mensaje;
    public int argumento;

    public string efecto;
    public int Costomana;


    public class Personaje : MonoBehaviour
    {
        public List<Accion> Acciones;

        public string nombre;
        public int vida;
        public int mana;

        void CambiaVida(int cant)
        {
            vida += cant;
        
        }
        void CambioMana(int cant)
        {
            mana += cant;
        }

        //Animator anim;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    public IEnumerator EjecutarAccion (Accion accion, Transform objetivo)
    {
      //  CambioMana(-accion.mana);

        if (accion.objetivoEsel)
        {
            objetivo = transform;
        }
        if (accion.estatico)
        {
            objetivo.SendMessage(accion.mensaje, accion.argumento);
        }
        else
        {
            Vector3 PosInicial = transform.position;
            //nv
            while (Vector3.Distance(transform.position, objetivo.position) > 2)
                yield return null;

            objetivo.SendMessage(accion.mensaje, accion.argumento);

          
            while (Vector3.Distance(transform.position, PosInicial) > 0.1f)
                yield return null;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
