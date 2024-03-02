using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimation : MonoBehaviour
{
    public float speed = 0.2f;
    public float strength = 9f;

    private float randomOffset;

    private void Start()
    {
        randomOffset = Random.Range(0f, 2f);
    }

    private void Update()
    {
        Vector3 position = transform.position;
        position.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
        transform.position = position;
    }
}
