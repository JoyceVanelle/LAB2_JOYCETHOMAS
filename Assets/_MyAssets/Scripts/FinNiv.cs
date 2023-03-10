using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class FinNiv : MonoBehaviour
{
    //Attribut 
    private bool isFinis = false;
    private GestionJeu _gestionJeu;
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }


    public void SetFinis(bool bloop)
    {
        isFinis = bloop;
    }

    //Termine le niveau et enregistre les temps 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SetFinis(true);
            Debug.Log("Game Over votre temps est de " + Time.time + " avec une pénaliter de " + _gestionJeu.GetPoint() + " accrochage, pour un total de " + (_gestionJeu.GetPoint() + Time.time));
            _player.FinPartie();
        }
    }
}
