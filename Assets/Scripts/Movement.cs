using UnityEngine;
using UnityEngine.InputSystem; 
public class NewMonoBehaviourScript : MonoBehaviour
{

   [SerializeField] InputAction thrust; 
   // We have to add bindings to the script (bindings = space)

    private void OnEnable()
    {
        thrust.Enable();
    }

    void Update()
    {
        if (thrust.IsPressed() == true)
        {
            Debug.Log("Hello");
        }
    }



}
