using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    
    [SerializeField] private float rateOfFire = 0.2f;

    [SerializeField] private GameObject bullet;

    [SerializeField] private List<GameObject> firePositions;

    private void Start()
    {
        StartCoroutine(Firing());
    }

    private void Fire()
    {
        foreach (GameObject position in firePositions)
            GameObject.Instantiate(bullet, position.transform.position, Quaternion.identity);
    }
    
    private IEnumerator Firing()
    {
        while(true)
        {
            Fire();
            yield return new WaitForSeconds(rateOfFire);
        }
    } 

}