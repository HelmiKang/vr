using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class gunController : MonoBehaviour
{
    
  [SerializeField]
  GameObject bulletPrefab;

   [SerializeField]
   Transform barrelEnd;

  ActionBasedController controller;
    // Start is called before the first frame update
 void Awake()
  {
    controller = GetComponent<ActionBasedController>();

    controller.activateAction.action.started += OnTriggerPress;

  }

    void OnTriggerPress(InputAction.CallbackContext context)
  {
    XRRayInteractor interactor = GetComponentInChildren<XRRayInteractor>();

    foreach (IXRSelectInteractable interactable in interactor.interactablesSelected)
    {
      GameObject probablyGun = interactable.transform.gameObject;

      if (probablyGun.TryGetComponent<gunController>(out gunController c))
      {
        c.PullTrigger();
      }
    }

    Instantiate(bulletPrefab, transform.position, transform.rotation);

  }
  public void PullTrigger()
  {
    Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
  }

    // Update is called once per frame
    void Update()
    {
        
    }
}
