using UnityEngine;
using System.Collections;

public class ColumnPool : MonoBehaviour 
{
    public GameObject columnPrefab;                                 
    public int columnPoolSize = 5;                                  
    public float spawnRate = 3.8f;                                 
    public float columnMin = -2f;                                  
    public float columnMax = 3.5f;                                 
    private GameObject[] columns;                                 
    private int currentColumn = 0;                                
    private Vector2 objectPoolPosition = new Vector2 (-10,-2);     
    private float spawnXPosition = 10f;

    private float LastTime;


    void Start()
    {
        LastTime = 0f;

        //Initialize the columns collection.
        columns = new GameObject[columnPoolSize];
        //Loop through the collection... 
        for(int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        LastTime += Time.deltaTime;

        if (GameControl.instance.gameOver == false && LastTime >= spawnRate) 
        {   
            LastTime = 0f;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn ++;

            if (currentColumn >= columnPoolSize) 
            {
                currentColumn = 0;
            }
        }
    }
}