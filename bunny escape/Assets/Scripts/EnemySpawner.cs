using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    //game object for creating

    public GameObject enemy;
    public float spawnrates;

    public float Xpositionlimit; // to store limit values 

    void Start()
    {
        Spawnmodule();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
       
    }
    void CreateSpikes()
    {
        float randomx = Random.Range(-Xpositionlimit,Xpositionlimit);
        Vector2 spawnPos = new Vector2(randomx, transform.position.y);
        Instantiate(enemy,spawnPos,Quaternion.identity);

    }

    void Spawnmodule()
    {
        InvokeRepeating("CreateSpikes",1f,spawnrates);
    }

    void CancelsSpawn() {
        CancelInvoke("CreateSpikes");
    }
}
