using UnityEngine;
using UnityEngine.InputSystem;

public sealed class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private PlayerControllerSettingsSO settings;
    private Rigidbody _rb;
    private Vector2 _movement;

    private void Awake()
    {
        Debug.Log("This runs first.");
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Debug.Log("This runs second.");
        moveAction.action.Enable();
    }

    private void Update()
    {
        Debug.LogWarning("This runs every rendered frame.");
        _movement = moveAction.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Debug.LogError("This runs at a fixed interval.");
        Vector3 direction = new(_movement.x, 0f, _movement.y);
        Vector3 velocity = direction * settings.MoveSpeed;
        _rb.linearVelocity = new Vector3(velocity.x, _rb.linearVelocity.y, velocity.z);
    }

    private void OnDisable()
    {
        Debug.Log("This runs when the object is disabled.");
        moveAction.action.Disable();
    }
}
