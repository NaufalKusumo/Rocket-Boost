using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem; 
public class NewMonoBehaviourScript : MonoBehaviour
{

   [SerializeField] InputAction thrust; 
   // We have to add bindings to the script (bindings = space)
   [SerializeField] float thrustStrength = 500f;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        thrust.Enable();
    }

    void FixedUpdate()
    {
        if (thrust.IsPressed() == true)
        {
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime); // Applies force in the object’s local space.
        }
    }



}
