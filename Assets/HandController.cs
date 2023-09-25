using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    // Start is called before the first frame update
    ActionBasedController controller;
    void Awake()
    {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTriggerPress;
    }

    void OnTriggerPress(InputAction.CallbackContext context)
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    
    void Update()
        {

        }
    
}
