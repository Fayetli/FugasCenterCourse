using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private float addForce;
    [SerializeField] private GameObject prefab;

    private const int COUNT_TO_SPAWN = 5;

    private void Start()
    {
        SpawnMorePrefab();
    }

    private void SpawnPrefab()
    {
        GameObject generatedObject = Instantiate(prefab);
        generatedObject.transform.position = new Vector2(0, 1);
    }

    private void SpawnMorePrefab()
    {
        for (int i = 0; i < COUNT_TO_SPAWN; i++)
        {
            GameObject generatedObject = Instantiate(prefab, new Vector2(0.01f * i, i), Quaternion.identity);
            SpriteRenderer renderer = generatedObject.GetComponent<SpriteRenderer>();
            renderer.color = new Color(i * 0.2f, i * 0.2f, i * 0.2f);

            if (generatedObject.TryGetComponent<Rigidbody2D>(out var rb))
            {
                rb.AddForce(new Vector2(i * addForce, 0f));
            }

        }
    }
}
