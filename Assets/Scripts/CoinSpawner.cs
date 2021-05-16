﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] public Transform myPrefab;

    [SerializeField] public Vector3 Spawnposition;
    [SerializeField] public float rotX;


    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < 25; i++){
        int rand1 = UnityEngine.Random.Range(-25,25);
        int rand2 = UnityEngine.Random.Range(-25,25);
        Instantiate(myPrefab,new Vector3(rand1,1,rand2),Quaternion.Euler(rotX,0f,0f));
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
