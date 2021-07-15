using UnityEngine;
public class Sensor_01 : MonoBehaviour
{
    [SerializeField] private bool isDetected_01;
    private void Start()
    {
        IsDetected_01 = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        IsDetected_01 = true;
    }
    private void OnTriggerExit(Collider other)
    {
        IsDetected_01 = false;
    }
    public bool IsDetected_01
    {
        set
        {
            this.isDetected_01 = value;
            Main_Process.sensors.sensorM001 = isDetected_01;
        }
    }
}
