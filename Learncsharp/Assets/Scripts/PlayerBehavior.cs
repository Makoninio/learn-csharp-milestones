using UnityEngine;
using UnityEngine.InputSystem; // <-- new system namespace

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float vInput;
    private float hInput;

    public float jumpVelocity = 5f;
    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;       

    private Rigidbody _rb;
    private CapsuleCollider _col;

    public GameObject bullet;
    public float bulletSpeed = 100f;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        // 4    void Update()
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        // 5
        this.transform.Translate(Vector3.forward * vInput *
        Time.deltaTime);
        // 6
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }

    // 1
    void FixedUpdate()
    {
        // 2
        Vector3 rotation = Vector3.up * hInput;
        // 3
        Quaternion angleRot = Quaternion.Euler(rotation *
        Time.fixedDeltaTime);
        // 4
        _rb.MovePosition(this.transform.position +
        this.transform.forward * vInput * Time.fixedDeltaTime);
        // 5
        _rb.MoveRotation(_rb.rotation * angleRot);

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);

        // 2
    if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet,
            this.transform.position + new Vector3(1, 0, 0),
            this.transform.rotation) as GameObject;
            // 4
            Rigidbody bulletRB =
            newBullet.GetComponent<Rigidbody>();
            // 5
            bulletRB.linearVelocity = this.transform.forward *
            bulletSpeed;
        }
        

}
    
    // 6
    private bool IsGrounded()
    {
        // 7
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
        _col.bounds.min.y, _col.bounds.center.z);
        // 8
        bool grounded = Physics.CheckCapsule(_col.bounds.center,
        capsuleBottom, distanceToGround, groundLayer,
        QueryTriggerInteraction.Ignore);
        // 9
        return grounded;
    }
}
