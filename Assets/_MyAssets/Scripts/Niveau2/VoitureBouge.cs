using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoitureBouge : MonoBehaviour
{
    [SerializeField] float vitesse;


    void Update()
    {
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime); //Bouge la voiture dans la direction qu'elle regarde
    }
}
