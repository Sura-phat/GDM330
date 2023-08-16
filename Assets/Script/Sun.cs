using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public GameObject SunPrefab;
    public float respawnTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemy()
    {
        GameObject a = Instantiate(SunPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-))
    }
}
