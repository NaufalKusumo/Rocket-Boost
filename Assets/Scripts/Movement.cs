using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem; 
public class NewMonoBehaviourScript : MonoBehaviour
{

   [SerializeField] InputAction thrust; 
   // We have to add bindings to the script (bindings = space)
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
            rb.AddRelativeForce(0, 30 ,0 ); // Applies force in the object’s local space.
        }
    }



}
