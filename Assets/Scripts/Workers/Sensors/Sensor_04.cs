using UnityEngine;
public class Sensor_04 : MonoBehaviour
{
    [SerializeField] private bool isDetected_04;
    private void Start()
    {
        IsDetected_04 = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        IsDetected_04 = true;
    }
    private void OnTriggerExit(Collider other)
    {
        IsDetected_04 = false;
    }
    public bool IsDetected_04
    {
        set
        {
            this.isDetected_04 = value;
            Main_Process.sensors.sensorM003B = isDetected_04;
        }
    }
}