using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    [SerializeField] GameObject pipePrefab;
    private GameObject pipe;
    [SerializeField] private float elapsedTime;
    [SerializeField] private float spawnRate = 1;

    [SerializeField] private float spawnPos = 1;
    [SerializeField] private float minHight;
    [SerializeField] private float maxHight;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            pipe = Instantiate(pipePrefab, new Vector3(spawnPos, Random.Range(minHight, maxHight), 0), transform.rotation);
            Destroy(pipe,5);
    }
}
