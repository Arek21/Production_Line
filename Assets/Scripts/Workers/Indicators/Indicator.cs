using UnityEngine;
public class Indicator : MonoBehaviour
{
    [Header("Indicator")]
    [SerializeField] private bool islight = false;

    private void Update()
    {
        if (islight == true) GetComponent<Renderer>().material.color = Color.red;
        if (islight == false) GetComponent<Renderer>().material.color = Color.white;
    }
}
