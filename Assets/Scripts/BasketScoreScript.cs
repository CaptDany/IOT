using UnityEngine;

public class BasketScoreScript : MonoBehaviour
{
    public string bluetoothMessage = "bucket"; // Message to send to ESP32 via Bluetooth when scored.
    public int score = 0; // Current score.

    public void IncrementScore()
    {
        score++;
        SendBluetoothMessage(bluetoothMessage);
    }

    private void SendBluetoothMessage(string message)
    {
        Debug.Log("Sending Bluetooth message: " + message);
    }
}
