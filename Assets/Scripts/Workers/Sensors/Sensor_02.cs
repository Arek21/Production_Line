using UnityEngine;
public class Sensor_02 : MonoBehaviour
{
    [SerializeField] private bool isDetected_02;
    private void Start()
    {
        IsDetected_02 = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        IsDetected_02 = true;
    }
    private void OnTriggerExit(Collider other)
    {
        IsDetected_02 = false;
    }
    public bool IsDetected_02
    {
        set
        {
            this.isDetected_02 = value;
            Main_Process.sensors.sensorM002 = isDetected_02;
        }
    }
}