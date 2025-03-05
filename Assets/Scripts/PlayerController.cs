using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Move Variables")]
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 moveInput;

    [Header("Interact Variable")]
    [SerializeField] bool interact;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(interact){
            interact = false;
            TryInteract();
        }
    }

    private void FixedUpdate(){
        rb.linearVelocity = moveInput.normalized * moveSpeed;
    }

    public void OnMoveInput(InputAction.CallbackContext context){
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnInteractInput(InputAction.CallbackContext context){
        if(context.phase == InputActionPhase.Performed){
            interact = true;
        }
    }

    private void TryInteract(){
        Debug.Log("Pressed Interact button");
    }
}
