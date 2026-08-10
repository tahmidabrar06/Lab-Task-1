using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private CharacterController cc;
    private Camera cam;
    private InputAction moveAction;
    private InputAction attackAction;
    private LayerMask layerMask;
    public float speed;
    public float gravity = -9.8f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = transform.GetComponent<CharacterController>();
        cam = transform.GetChild(0).GetComponent<Camera>();
        moveAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Attack");
        layerMask = LayerMask.GetMask("Target");
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.WasPressedThisFrame())
        {
            Shoot();
            //Debug.Log("presed attack");
        }
        PlayerMovement();
    }

    void PlayerMovement()
    {
        Vector2 moveDir = moveAction.ReadValue<Vector2>();
        Vector3 movement = transform.right * moveDir.x + transform.forward * moveDir.y;
        cc.Move(movement * speed * Time.deltaTime);
    }

    void Shoot()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        { 
            hit.transform.GetComponent<Target>().Hit();
        }

    }
}
