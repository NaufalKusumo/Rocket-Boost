using UnityEngine;
using UnityEngine.InputSystem; 
public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] InputAction thrust;

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
