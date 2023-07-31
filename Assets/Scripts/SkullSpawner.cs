using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject basketballPrefab; // Drag and drop the basketball prefab to this variable in the Inspector.
    public float spawnInterval = 2f; // Time interval between spawning basketballs.
    public float upwardForce = 10f; // The force applied to make the basketball go upwards.
    public float forwardForce = 5f; // The force applied to make the basketball move forward.
    public float randomDeviation = 2f; // Random deviation for the direction of the basketball.

    private Coroutine spawnCoroutine;

    private void Start()
    {
        // Start spawning basketballs.
        spawnCoroutine = StartCoroutine(SpawnBasketballs());
    }

    private void OnDestroy()
    {
        // Stop the coroutine when this object is destroyed.
        if (spawnCoroutine != null)
            StopCoroutine(spawnCoroutine);
    }

    private IEnumerator SpawnBasketballs()
    {
        while (true)
        {
            // Create a new basketball instance at the spawner's position and rotation.
            GameObject basketball = Instantiate(basketballPrefab, transform.position, Quaternion.identity);

            // Get the rigidbody of the basketball.
            Rigidbody rb = basketball.GetComponent<Rigidbody>();

            // Calculate the direction vector with slight random deviation.
            Vector3 direction = Quaternion.Euler(Random.Range(-randomDeviation, randomDeviation), Random.Range(-randomDeviation, randomDeviation), 0f) * Vector3.forward;

            // Apply the initial forces to the basketball.
            rb.AddForce(direction.normalized * forwardForce, ForceMode.VelocityChange);
            rb.AddForce(Vector3.up * upwardForce, ForceMode.VelocityChange);

            // Wait for the next spawn interval.
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
