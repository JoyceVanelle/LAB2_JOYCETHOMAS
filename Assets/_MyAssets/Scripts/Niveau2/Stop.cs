using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Creer une liste de voiture pour la route
        [SerializeField] private List<GameObject> _char = new List<GameObject>();
        [SerializeField] private float _vitesse = 200;

    }

    //ON trigger enter pour faire bouger les voitures
    private void OnTriggerEnter(Collider other)
    {

    }
}
