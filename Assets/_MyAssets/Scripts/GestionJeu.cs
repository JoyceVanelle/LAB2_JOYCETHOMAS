using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs
    private int _pointage;

    private void Instructions()
    {
        _pointage = 0;
        Debug.Log("*** Course a obstacle ***");
        Debug.Log("Atteind la fin du parkour le plus vite possible!");
        Debug.Log("Chaque obstacle touch� entraine une p�nalit�");
    }
    void Start()
    {
        Instructions(); 
    }

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochage : " + _pointage);
    }

    public int GetPoint() { return _pointage; }

    // Update is called once per frame
    void Update()
    {
        
    }
}