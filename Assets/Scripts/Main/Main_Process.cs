using S7.Net;
using System.Threading.Tasks;
using UnityEngine;
using System;
using System.Threading;
using System.ComponentModel;

public class Main_Process : MonoBehaviour
{
    public class Sensors
    {
        public bool sensorM001 { get; set; }
        public bool sensorM002 { get; set; }
        public bool sensorM003A { get; set; }
        public bool sensorM003B { get; set; }
        public bool sensorM004 { get; set; }
    }
    public class Workers
    {
        public bool workM001 { get; set; }
        public bool workM002 { get; set; }
        public bool workM003A { get; set; }
        public bool workM003B { get; set; }
        public bool workM004 { get; set; }
    }
    public class Conveyors
    {
        public bool runConveyor01 { get; set; }
        public bool runConveyor02 { get; set; }
        public bool runConveyor03A { get; set; }
        public bool runConveyor03B { get; set; }
        public bool runConveyor04A { get; set; }
        public bool runConveyor04B { get; set; }

    }

    public static Sensors sensors = new Sensors();
    public static Workers workers = new Workers();
    public static Conveyors conveyors = new Conveyors();

    BackgroundWorker backgroundWorker = new BackgroundWorker();
    private static Plc plc = new Plc(CpuType.S71500, "127.0.0.1", 0, 1);

    // Start is called before the first frame update
    private void Start()
    {
        plc.Open();
        backgroundWorker.DoWork += BackgroundWorker_DoWork;
    }

    private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        UpdateDataToPLC();
        GetDataFromPLC();
    }

    private void OnDestroy()
    {
        plc.Close();
    }

    // Update is called once per frame
    private void Update()
    {
        try
        {
            if (!backgroundWorker.IsBusy) backgroundWorker.RunWorkerAsync();

        }
        catch (PlcException plcException)
        {
            Debug.Log("PLC EXCEPTION " + plcException.ErrorCode);
        }
        catch (UnityException e)
        {
            Debug.Log("UNITY EXCEPTION " + e.Message);
        }
        catch (Exception e)
        {
            Debug.Log("OTHER EXCEPTION " + e.Message);
        }

    }

    private void GetDataFromPLC()
    {
        if (plc != null)
        {
            if (!plc.IsConnected) plc.Open();

            plc.ReadClass(workers, 9);
            plc.ReadClass(conveyors, 10);
        }
    }

    private void UpdateDataToPLC()
    {
        if (plc != null)
        {
            if (!plc.IsConnected) plc.Open();

            plc.WriteBit(DataType.Input, 1, 0, 0, sensors.sensorM001);
            plc.WriteBit(DataType.Input, 1, 0, 1, sensors.sensorM002);
            plc.WriteBit(DataType.Input, 1, 0, 2, sensors.sensorM003A);
            plc.WriteBit(DataType.Input, 1, 0, 3, sensors.sensorM003B);
            plc.WriteBit(DataType.Input, 1, 0, 4, sensors.sensorM004);
        }
    }
}
