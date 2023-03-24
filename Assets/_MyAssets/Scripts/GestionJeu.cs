using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs
    private int _pointage;
    Player _tempsdebut;
    float _tempsdeduction;
    string _messageFinal = "";
    private Player _player;
    private float _tempTot = 0;
    private float _tempNiv;

    private void Awake()
    {
        // Vérifie si un gameObject GestionJeu est déjà présent sur la scène si oui
        // on détruit celui qui vient d'être ajouté. Sinon on le conserve pour le 
        // scène suivante.
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Instructions()
    {
        _pointage = 0;
        Debug.Log("*** Course a obstacle ***");
        Debug.Log("Atteind la fin du parkour le plus vite possible!");
        Debug.Log("Chaque obstacle touché entraine une pénalité");
       
    }
    void Start()
    {
        Instructions();
        _tempsdebut = FindObjectOfType<Player>();
        _player = FindObjectOfType<Player>();
        _tempsdeduction = _tempsdebut.getTempsdebut();
    }
    
    public void FinNiveau()
    {
        float _tempNiv;
        int accrochage;
        int _niv = 0;
        _niv++; 
        _tempNiv = (Time.time - _player.getTempsdebut());
        _tempTot += GetTempNiv();
        accrochage = GetPoint();
        _messageFinal += "Niveau " + _niv + " Temps du niveau: " + _tempNiv + " Nombre accrochage: " + accrochage;
    }

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochage : " + _pointage);
    }

    public int GetPoint() { return _pointage; } //Pour aller chercher les points 

    public float GetTempNiv() { return _tempNiv; }

    public float GetTemp() { return _tempsdeduction;} // Pour aller chercher le temps reductions
  
    public string GetMess() { return _messageFinal; } // va chercher le message finale

    public float GetTempTot() { return _tempTot; } 
    
}
