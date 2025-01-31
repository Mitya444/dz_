using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinteraction : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            float interactRange = 5f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out NPcinteraction npcInteractable))
                {
                    npcInteractable.Interact();
                }
            }
        }
    }
}
