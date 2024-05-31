using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] BoxCollider2D spawnArea;

    private void Start()
    {
        RandomPositionFood();
    }

    public void RandomPositionFood()
    {
        Bounds bounds = spawnArea.bounds;

        Vector2 randomArea = new Vector2(Random.Range(bounds.min.x, bounds.max.x), Random.Range(bounds.min.y, bounds.max.y));

        float roundXPos = Mathf.Round(randomArea.x);
        float roundYPos = Mathf.Round(randomArea.y);

        transform.position = new Vector2(roundXPos, roundYPos);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            RandomPositionFood();
    }
}
