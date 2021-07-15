using UnityEngine;

public class Setup_Element : MonoBehaviour
{
    [Header("Workers")]
    [SerializeField] private bool worker_M002 = false;
    [SerializeField] private bool worker_M003A = false;
    [SerializeField] private bool worker_M003B = false;

    private bool isInZone1 = false;
    private bool isInZone2 = false;
    private bool isInZone3 = false;

    private void Update()
    {
        if (worker_M002 == true && isInZone1 == true) GetComponent<Renderer>().material.color = Color.white;
        if (worker_M003A == true && isInZone2 == true)
        {

        }
        if (worker_M003B == true && isInZone3 == true)
        {

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "MovingSurface") transform.SetParent(collision.gameObject.transform);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "MovingSurfaceCollider") transform.parent = null;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Zone1")) isInZone1 = true;
        if (other.gameObject.tag.Equals("Zone2")) isInZone2 = true;
        if (other.gameObject.tag.Equals("Zone3")) isInZone3 = true;

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Zone1") isInZone1 = false;
        if (other.gameObject.tag == "Zone2") isInZone2 = false;
        if (other.gameObject.tag == "Zone3") isInZone3 = false;
    }
}
