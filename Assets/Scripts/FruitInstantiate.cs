using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitInstantiate : MonoBehaviour
{
    

    public GameObject objectToInstantiate;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float delay = 2f;
    public float destroyDelay = 5f;

    IEnumerator Start()
    {
        while (true)
        {
            // Calculate a random position between the min and max X and Z values
            Vector3 randomPosition = new Vector3(
                Random.Range(minX, maxX),
                1.31f,
                Random.Range(minZ, maxZ)
            );

            // Instantiate the object at the calculated position
            GameObject instantiatedObject = Instantiate(objectToInstantiate, randomPosition, Quaternion.identity);

            // Destroy the object after the specified delay
            Destroy(instantiatedObject, destroyDelay);

            // Wait for the specified delay before instantiating the next object
            yield return new WaitForSeconds(delay);
        }
    }
}
