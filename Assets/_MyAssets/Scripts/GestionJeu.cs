using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs
    private int _pointage;
    Player _tempsdebut;
    float _tempsdeduction;
    

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
        _tempsdeduction = _tempsdebut.getTempsdebut();
    }
    

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochage : " + _pointage);
    }

    public int GetPoint() { return _pointage; }

  
    
    
}
