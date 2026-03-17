using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeBehaivior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;


    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        /*if (transform.position.x < endPos)
            transform.position = new Vector3(spawnPos, Random.Range(minHight, maxHight), transform.position.z);*/
    }

    private void Start()
    {
        Destroy(gameObject, 3f);
    }
}
