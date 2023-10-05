using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    public static EnemySpawner Instance;

    [SerializeField]
    private GameObject enemyPrefab;
    
    
    void Awake()
    {
        if(Instance == null)
            Instance = this;
    }
    void Start()
    {
        SpawnEnemy();
    }
    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
   





}
