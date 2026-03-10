using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 20f;
    public float xRange = 15f;
    public GameObject projectilePrefab;
    public GameObject pauseWindow;
    public InputActionAsset InputActions;
    private InputAction moveAction;
    private InputAction fireAction;
    private InputAction pauseActionPlayer;
    private InputAction pauseActionUI;
    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        fireAction = InputSystem.actions.FindAction("Jump");
        pauseActionPlayer = InputSystem.actions.FindAction("Pause/Player");
        pauseActionUI = InputSystem.actions.FindAction("Pause/UI");
    }
    void Update()
    {
        float horizontalInput = moveAction.ReadValue<Vector2>().x;
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        if ( transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.y);
        }
        if ( transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y);
        }
        if (fireAction.WasPressedThisFrame())
        {
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 2f, 0), projectilePrefab.transform.rotation);
        }
        if (pauseActionPlayer.WasPressedThisFrame())
        {
            
        }
        if (pauseActionUI.WasPressedThisFrame())
        {
            
        }
    }
}
