using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ballPrefab;
    private GameObject currentBall;
    public Vector3 position;

    public void SpawnBallAtPosition()
    {
        if (currentBall != null)
        {
            Destroy(currentBall);
        }
        currentBall = Instantiate(ballPrefab, position, Quaternion.identity);
    }
}
