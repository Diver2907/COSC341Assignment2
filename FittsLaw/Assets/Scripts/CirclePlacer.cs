using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePlacer : MonoBehaviour
{
    public GameObject circlePrefab; // Assign your circle prefab in the inspector
    public float radius = 5f; // The radius of the large circle

    void Start()
    {
        PlaceCircles();
    }

    void PlaceCircles()
    {
        int numberOfCircles = 9;
        float angleStep = 360f / numberOfCircles;

        for (int i = 0; i < numberOfCircles; i++)
        {
            float angle = i * angleStep * Mathf.Deg2Rad; // Convert angle to radians
            float x = radius * Mathf.Cos(angle);
            float y = radius * Mathf.Sin(angle);

            Vector2 position = new Vector2(x, y);
            var newObject = (GameObject) Instantiate(circlePrefab, position, Quaternion.identity);
            newObject.name = "Circle" + i;
        }

        Destroy(circlePrefab);
    }
}
