using UnityEngine;
public class Sensor_03B : MonoBehaviour
{
    [SerializeField] private bool isDetected_03B;
    private void Start()
    {
        IsDetected_03B = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        IsDetected_03B = true;
    }
    private void OnTriggerExit(Collider other)
    {
        IsDetected_03B = false;
    }
    public bool IsDetected_03B
    {
        set
        {
            this.isDetected_03B = value;
            Main_Process.sensors.sensorM003B = isDetected_03B;
        }
    }
}