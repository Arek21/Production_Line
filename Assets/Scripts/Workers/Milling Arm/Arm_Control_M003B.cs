using UnityEngine;
public class Arm_Control_M003B : MonoBehaviour
{
    [Header("Enable animation")]
    [SerializeField] private bool isMillingMachine_B_Works = false;

    public Animator animator;

    private void Update()
    {
        animator.SetBool("worker_M003B", isMillingMachine_B_Works);
    }
}
