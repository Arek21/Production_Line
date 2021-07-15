using UnityEngine;
public class Indicator_M002 : MonoBehaviour
{
    [Header("Indicator")]
    [SerializeField] private bool islight = false;

    private void Update()
    {
        this.islight = Main_Process.workers.workM002;
        if (islight) GetComponent<Renderer>().material.color = Color.red;
        else GetComponent<Renderer>().material.color = Color.white;
    }
}