using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour
{
    public float interactDistance = 5f;

    void Update()
    {
        CheckRay();
    }

    void CheckRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            if (hit.collider.CompareTag("Rock") && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Rock breakable = hit.collider.GetComponent<Rock>();

                if (breakable != null)
                {
                    breakable.TakeDamage(1);
                }
            }
        }
    }
}
