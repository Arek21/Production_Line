using UnityEngine;
public class Sensor_03A : MonoBehaviour
{
    [SerializeField] private bool isDetected_03A;
    private void Start()
    {
        IsDetected_03A = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        IsDetected_03A = true;
    }
    private void OnTriggerExit(Collider other)
    {
        IsDetected_03A = false;
    }
    public bool IsDetected_03A
    {
        set
        {
            this.isDetected_03A = value;
            Main_Process.sensors.sensorM001 = isDetected_03A;
        }
    }
}