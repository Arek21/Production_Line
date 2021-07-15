using UnityEngine;
public class Indicator_M003A : MonoBehaviour
{
    [Header("Indicator")]
    [SerializeField] private bool islight = false;

    private void Update()
    {
        this.islight = Main_Process.workers.workM003A;
        if (islight) GetComponent<Renderer>().material.color = Color.red;
        else GetComponent<Renderer>().material.color = Color.white;
    }
}
