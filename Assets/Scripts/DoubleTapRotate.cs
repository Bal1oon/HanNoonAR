using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapRotate : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // Rotation axis selected in the Inspector
    public float rotationSpeed = 90f; // Rotation speed
    public float doubleTapTimeThreshold = 0.3f; // Time threshold for detecting double taps

    private bool isRotating = false;
    private float lastTapTime = 0f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        if (Time.time - lastTapTime <= doubleTapTimeThreshold)
                        {
                            // Start rotation if double tap is detected
                            if (!isRotating)
                            {
                                isRotating = true;
                                StartCoroutine(RotateObject());
                            }
                        }
                        else
                        {
                            lastTapTime = Time.time;
                        }
                    }
                }
            }
        }
    }

    IEnumerator RotateObject()
    {
        float elapsedTime = 0f;
        Quaternion startingRotation = transform.rotation;

        while (elapsedTime < 5f)
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            Quaternion rotation = Quaternion.AngleAxis(rotationAmount, rotationAxis);
            transform.rotation *= rotation;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isRotating = false;
        transform.rotation = startingRotation;
    }
}
