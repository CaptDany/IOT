using UnityEngine;

public class RimScript : MonoBehaviour
{
    public string bluetoothMessage = "rim"; // Message to send to ESP32 via Bluetooth when the rim is touched.
    private BasketScoreScript basketScoreScript; // Reference to the BasketScoreScript attached to the basket.
    private BluetoothComScript BTLogic; // Reference to the BluetoothComScript.

    private void Start()
    {
        BTLogic = GameObject.FindObjectOfType<BluetoothComScript>();
        basketScoreScript = FindObjectOfType<BasketScoreScript>();
        if (BTLogic == null)
        {
            Debug.LogError("BluetoothComScript not found!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            // The rim has been touched by a basketball.
            SendBluetoothMessage(bluetoothMessage);
            BTLogic.SendMessageToArduino("rim");
        }
    }

    private void SendBluetoothMessage(string message)
    {
        Debug.Log("Sending Bluetooth message: " + message);
    }
}
