using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
public class NewMonoBehaviourScript : MonoBehaviour
{

   [SerializeField] InputAction rotation;
   [SerializeField] InputAction thrust; 
   [SerializeField] float rotationStrength = 0;
   // We have to add bindings to the script (bindings = space)
   [SerializeField] float thrustStrength = 500f;
    Rigidbody rb;

    private quaternion originalRotation;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalRotation = transform.rotation;
    }
    private void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();
    }

    void FixedUpdate()
    {
        float rt = rotation.ReadValue<float>();

        if (thrust.IsPressed() == true)
        {
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime); // Applies force in the object’s local space.
        }
        if (rotation.IsPressed() == true)
        {
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * rt * -1 * rotationStrength * Time.fixedDeltaTime);
            rb.freezeRotation = false; 
        }
        // else{
        //     if(transform.rotation != originalRotation)
        //     {
        //         if(transform.rotation.z =)
        //     }
        // }
    }

}
