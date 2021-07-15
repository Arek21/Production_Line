using UnityEngine;
public class Arm_Control_M003A : MonoBehaviour
{
    [Header("Enable animation")]
    [SerializeField] private bool isMillingMachine_A_Works = false;

    public Animator animator;

    private void Update()
    {
        this.isMillingMachine_A_Works = Main_Process.workers.workM003A;
        animator.SetBool("worker_M003B", isMillingMachine_A_Works);
    }
}