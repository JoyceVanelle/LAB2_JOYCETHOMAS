using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeSphere : MonoBehaviour
{
    private bool _estActive = false;
    [SerializeField] private GameObject _piege = default;
    private Rigidbody _rb;
    [SerializeField] private float _intensiteForce = 500;


    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>(); //va chercher le Rb de l'objet
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_estActive && other.gameObject.tag == "Player")
        {
            _estActive = true;
            _rb.useGravity = true; //Active la gravité sur le rb
            _rb.AddForce(Vector3.back * _intensiteForce); //ajoute la force 

        }



    }
}
