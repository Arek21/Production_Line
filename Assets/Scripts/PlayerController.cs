using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float mouseSens = 16f;

    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }
    private void Update()
    {
        //Calculate movement velocity 3D vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _xMov;
        Vector3 _moveVertical = transform.forward * _zMov;

        //Final movement vector
        Vector3 _velocity = (_moveHorizontal + _moveVertical) * speed;

        //Apply movement
        motor.Move(_velocity);

        //Calculate rotation as 3D vector (turning around)
        float _yRot = Input.GetAxisRaw("Mouse X");
        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * mouseSens;

        //Apply rotation
        motor.Rotate(_rotation);

        //Calculate camer rotation as 3D vector (turning around)
        float _xRot = Input.GetAxisRaw("Mouse Y");
        //Vector3 _cameraRotation = new Vector3(_xRot, 0f, 0f) * mouseSens;
        float _cameraRotationX = _xRot * mouseSens;
        
        //Apply camera rotation
        motor.RotateCamera(_cameraRotationX);


        //Apply camera rotation
        //motor.RotateCamera(_cameraRotation);

    }
}
