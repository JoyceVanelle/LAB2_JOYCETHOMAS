using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.SceneManagement;

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
            _player.FinPartie();
            int noScene = SceneManager.GetActiveScene().buildIndex;
            if(noScene == 2)
            {
                //Mettre score
            }
            else
            {
                //Charge la scene suivante 
                SceneManager.LoadScene(noScene + 1);
            }
        }
    }
}
