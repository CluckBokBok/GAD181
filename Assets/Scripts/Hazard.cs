using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private float spawnPosY = 0;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private GameObject hazard;
    [SerializeField] private Vector3 pointA;
    [SerializeField] private Vector3 pointB;

    void Start()
    {
        spawnPosY = Random.Range(-3, 3);
        pointA = new Vector3 (8, spawnPosY, 0);
        pointB = new Vector3 (-8, spawnPosY, 0);

        StartCoroutine(Thing());

    }

    private IEnumerator Thing()
    {
        while (true)
        {
            transform.position = Vector3.Lerp(pointA, pointB, moveSpeed);
        }

        Destroy(hazard);
        yield return null;
    }
}
