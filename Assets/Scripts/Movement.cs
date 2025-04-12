using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
public class NewMonoBehaviourScript : MonoBehaviour
{

   [SerializeField] InputAction thrust; 
   [SerializeField] float rotationStrength = 0;
   // We have to add bindings to the script (bindings = space)
   [SerializeField] float thrustStrength = 500f;
   [SerializeField] InputAction rotation;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();
    }

    void FixedUpdate()
    {
        if (thrust.IsPressed() == true)
        {
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime); // Applies force in the object’s local space.
        }
        float rt = rotation.ReadValue<float>();
        if (rotation.IsPressed() == true)
        {
           transform.Rotate(Vector3.forward * rt * -1 * rotationStrength * Time.fixedDeltaTime);
           Debug.Log("Is ROTATING"); //Trying to fix rotating bug when hitting an object
           
        }
    }



}
