using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapRotate : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // Inspector에서 선택한 회전 축
    public float rotationSpeed = 90f; // 회전 속도
    public float doubleTapTimeThreshold = 0.3f; // 연속 터치 간 시간 임계값

    private bool isRotating = false;
    private float lastTapTime = 0f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (Time.time - lastTapTime <= doubleTapTimeThreshold)
                {
                    // 연속 터치 감지되면 회전 시작
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
