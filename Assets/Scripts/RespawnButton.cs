using UnityEngine;

public class RespawnButton : MonoBehaviour
{
    public GameObject basketballPrefab;

    public void OnRespawnButtonClicked()
    {
        // Check if there is an existing basketball in the scene.
        GameObject existingBasketball = GameObject.FindGameObjectWithTag("Basketball");
        if (existingBasketball != null)
        {
            // Destroy the existing basketball.
            Destroy(existingBasketball);
        }
    }
}
