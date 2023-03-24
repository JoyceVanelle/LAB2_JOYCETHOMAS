using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    //Attributs 
    private GestionJeu _gestionJeu;
    private bool _toucher = false;
    private float _tempstotal;
    private float _tempsNiv1;
    private float _tempsNiv2;
    private float _tempsNiv3;
    private float _point1;
    private float _point2;
    private float _point3;
    private float _pointTot;


    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();//get objet gestion de jeu
    }

    //Gestion collision et chagmeent de couleurs
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;//Changement de couleur
                _gestionJeu.AugmenterPointage();//Augmente pointage
                _toucher = true; //Defini objet comme toucher pour pas toucher trop de fois dans un trop petit delai
                Invoke("DelaiFin", 4);
            }

        }

    }

    private void DelaiFin() //Sert a remettre un object "Dans le jeu" pour qu'il soit retouché
    {
        _toucher= false; //remets l'objet touchable
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green; // change la couleur pour une couleur verte retouchable, mais previent quand meme que l'objet a deja ete toucher
    }


}
