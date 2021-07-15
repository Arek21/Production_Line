using UnityEngine;

public class Moving : MonoBehaviour
{
    #region Conveyors variables
    [Header("Conveyor Permissions")]
    [SerializeField] private bool conPermission_01 = false;
    [SerializeField] private bool conPermission_02 = false;
    [SerializeField] private bool conPermission_03A = false;
    [SerializeField] private bool conPermission_03B = false;
    [SerializeField] private bool conPermission_04A = false;
    [SerializeField] private bool conPermission_04B = false;
    #endregion

    #region Conveyors isGrounded varables
    private bool isGrounded_01 = false;
    private bool isGrounded_02 = false;

    private bool isGrounded_03 = false;
    private bool isGrounded_03A1 = false;
    private bool isGrounded_03A2 = false;
    private bool isGrounded_03B1 = false;
    private bool isGrounded_03B2 = false;

    private bool isGrounded_04A1 = false;
    private bool isGrounded_04A2 = false;
    private bool isGrounded_04B1 = false;
    private bool isGrounded_04B2 = false;
    private bool isGrounded_04 = false;
    #endregion

    void Update()
    {
        /*#region Upload Conveyor permissions to Main
        this.conPermission_01 = Main_Process.conveyors.runConveyor01;
        this.conPermission_02 = Main_Process.conveyors.runConveyor02;
        this.conPermission_03A = Main_Process.conveyors.runConveyor03A;
        this.conPermission_03B = Main_Process.conveyors.runConveyor03B;
        this.conPermission_04A = Main_Process.conveyors.runConveyor04A;
        this.conPermission_04B = Main_Process.conveyors.runConveyor04B;
        #endregion*/

        #region Conveyors permission
        if (conPermission_01 == true && isGrounded_01 == true) transform.position += new Vector3 (Time.deltaTime, 0, 0);
        if (conPermission_02 == true && isGrounded_02 == true && isGrounded_01 == false) transform.position += new Vector3 (Time.deltaTime, 0, 0);

        if (conPermission_03A == true && isGrounded_03 == true && isGrounded_02 == false) transform.position += new Vector3 (Time.deltaTime, 0, 0);
        if (conPermission_03A == true && isGrounded_03A1 == true && isGrounded_03 == false) transform.position += new Vector3(0, 0, -Time.deltaTime);
        if (conPermission_03B == true && isGrounded_03 == true && isGrounded_02 == false) transform.position += new Vector3(Time.deltaTime, 0, 0);
        if (conPermission_03B == true && isGrounded_03B1 == true && isGrounded_03 == false) transform.position += new Vector3(0, 0, Time.deltaTime);
        if (conPermission_03A == true && isGrounded_03A2 == true && isGrounded_03A1 == false) transform.position += new Vector3(Time.deltaTime, 0, 0);
        if (conPermission_03B == true && isGrounded_03B2 == true && isGrounded_03B1 == false) transform.position += new Vector3(Time.deltaTime, 0, 0);

        if (conPermission_04A == true && isGrounded_04A1 == true && isGrounded_03A2 == false) transform.position += new Vector3(Time.deltaTime, 0, 0);
        if (conPermission_04B == true && isGrounded_04B1 == true && isGrounded_03B2 == false) transform.position += new Vector3(Time.deltaTime, 0, 0);
        if (conPermission_04A == true && isGrounded_04A2 == true && isGrounded_04A1 == false) transform.position += new Vector3(0, 0, Time.deltaTime);
        if (conPermission_04B == true && isGrounded_04B2 == true && isGrounded_04B1 == false) transform.position += new Vector3(0, 0, -Time.deltaTime);
        if ((conPermission_04A == true || conPermission_04B == true) && isGrounded_04 == true && (isGrounded_04A2 == false && isGrounded_04B2 == false)) transform.position += new Vector3(Time.deltaTime, 0, 0);
        #endregion
    }
    private void OnCollisionEnter(Collision collision)
    {
        #region Conveyors Enter
        if (collision.gameObject.tag == "Conveyor_01")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_01 = true;
        }
        if (collision.gameObject.tag == "Conveyor_02")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_02 = true;
        }
        if (collision.gameObject.tag == "Conveyor_03")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_03 = true;
        }
        if (collision.gameObject.tag == "Conveyor_03A1")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_03A1 = true;
        }
        if (collision.gameObject.tag == "Conveyor_03A2")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_03A2 = true;
        }
        if (collision.gameObject.tag == "Conveyor_03B1")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_03B1 = true;
        }
        if (collision.gameObject.tag == "Conveyor_03B2")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_03B2 = true;
        }
        if (collision.gameObject.tag == "Conveyor_04A1")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_04A1 = true;
        }
        if (collision.gameObject.tag == "Conveyor_04B1")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_04B1 = true;
        }
        if (collision.gameObject.tag == "Conveyor_04A2")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_04A2 = true;
        }
        if (collision.gameObject.tag == "Conveyor_04B2")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_04B2 = true;
        }
        if (collision.gameObject.tag == "Conveyor_04")
        {
            transform.SetParent(collision.gameObject.transform);
            isGrounded_04 = true;
        }
        #endregion
     }
    private void OnCollisionExit(Collision collision)
    {
        #region Conveyors Exit
        if (collision.gameObject.tag == "Conveyor_01")
        {
            transform.parent = null;
            isGrounded_01 = false;
        }
        if (collision.gameObject.tag == "Conveyor_02")
        {
            transform.parent = null;
            isGrounded_02 = false;
        }
        if (collision.gameObject.tag == "Conveyor_03")
        {
            transform.parent = null;
            isGrounded_03 = false;
        }
        if (collision.gameObject.tag == "Conveyor_03A1")
        {
            transform.parent = null;
            isGrounded_03A1 = false;
        }
        if (collision.gameObject.tag == "Conveyor_03A2")
        {
            transform.parent = null;
            isGrounded_03A2 = false;
        }
        if (collision.gameObject.tag == "Conveyor_03B1")
        {
            transform.parent = null;
            isGrounded_03B1 = false;
        }
        if (collision.gameObject.tag == "Conveyor_03B2")
        {
            transform.parent = null;
            isGrounded_03B2 = false;
        }
        if (collision.gameObject.tag == "Conveyor_04A1")
        {
            transform.parent = null;
            isGrounded_04A1 = false;
        }
        if (collision.gameObject.tag == "Conveyor_04B1")
        {
            transform.parent = null;
            isGrounded_04B1 = false;
        }
        if (collision.gameObject.tag == "Conveyor_04A2")
        {
            transform.parent = null;
            isGrounded_04A2 = false;
        }
        if (collision.gameObject.tag == "Conveyor_04B2")
        {
            transform.parent = null;
            isGrounded_04B2 = false;
        }
        if (collision.gameObject.tag == "Conveyor_04")
        {
            transform.parent = null;
            isGrounded_04 = false;
        }
        #endregion
    }
}
