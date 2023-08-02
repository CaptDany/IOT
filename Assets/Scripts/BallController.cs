using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ballPrefab;  // Assign your Ball prefab in the inspector
    public Transform startPoint; // Assign your start point in the inspector
    public Transform endPoint; // Assign your end point in the inspector
    private GameObject currentBall;
    private void SpawnAndJumpBall()
    {
        // If a ball already exists, we destroy it.
        if (currentBall != null)
        {
            Destroy(currentBall);
        }
        // Instantiate new ball object at the start point position
        currentBall = Instantiate(ballPrefab, startPoint.position, Quaternion.identity);
        // Make your ball jump to the endPoint position
        currentBall.GetComponent<Rigidbody>().AddForce((endPoint.position - startPoint.position) * 2, ForceMode.VelocityChange);
    }
}
