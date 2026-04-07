using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{
    
    [SerializeField] GameObject pipePrefab;
    [SerializeField] private float elapsedTime;
    [SerializeField] private float spawnRate = 1;

    [SerializeField] private float spawnPos = 1;
    [SerializeField] private float minHight;
    [SerializeField] private float maxHight;
    
    void Start()
    {
        // StartCoroutine(SpawnPipeRoutine());
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnRate)
        {
            SpawnPipe();
            elapsedTime = 0;
        }
    }

    private void SpawnPipe()
    {
        Instantiate(pipePrefab, new Vector2(spawnPos, Random.Range(minHight, maxHight)), transform.rotation);
    }
    //* Alternate Method
    // IEnumerator SpawnPipeRoutine()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(spawnRate);
    //         SpawnPipe();
    //     }
    // }
    
}
