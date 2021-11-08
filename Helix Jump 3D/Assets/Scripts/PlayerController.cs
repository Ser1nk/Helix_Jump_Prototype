using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    [SerializeField] private GameObject VictoryPanel;
    [SerializeField] private GameObject LosePanel;

    private Rigidbody _rigidbody;

    private const string isGround = "Ground";
    private const string Victory = "Victory";
    private const string Death = "Death";

    private bool _isGrounded;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (_isGrounded == true)
        {
            _rigidbody.velocity = new Vector3(0, jumpForce, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(isGround))
        {
            _isGrounded = true;
        }

        if (other.CompareTag(Victory))
        {
            VictoryPanel.SetActive(true);
        }

        if (other.CompareTag(Death))
        {
            LosePanel.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(isGround))
        {
            _isGrounded = false; 
        }
    }
}
