using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab; //og enemy
    public GameObject enemyTwoPrefab; //DVD enemy
    public GameObject CoinPrefab; //coin (functioning like enemy)
    public GameObject ShieldPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 4, 5); //spawn new enemy type
        InvokeRepeating("CreateCoin", 1, 2); //spawn coins
        InvokeRepeating("CreateShield", 5, 10); // rare shield
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
    void CreateEnemyTwo()
    { Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity); 
    }
    void CreateCoin()
    {
        float randomX = Random.Range(-9f, 9f); // horizontal
        float randomY = Random.Range(-4f, 0f); // within player's range
        Instantiate(CoinPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }

    //shield
    void CreateShield()
    {
        float randomX = Random.Range(-9f, 9f);
        float randomY = Random.Range(-4f, 0f);
        Instantiate(ShieldPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }

}
