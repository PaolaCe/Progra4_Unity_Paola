using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip1 : MonoBehaviour
{
   

    public class Formas
    {
        public int vida;
        public int ataque;
        public int defensa;

        public void Atacar()
        {
            vida = vida -1;
        }


        public void Mostrar()
        {
            Debug.Log("Si te ataco la figura");
            Debug.Log(vida);
        }
    

    }

}
