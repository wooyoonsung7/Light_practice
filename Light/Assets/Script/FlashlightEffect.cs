using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightEffect : MonoBehaviour
{
    public Light flashlight;
    public float intensity = 1f;

    void Start()
    {
        // �÷��ö���Ʈ �⺻ ����
        flashlight.type = LightType.Spot;
        flashlight.range = 10f;
        flashlight.spotAngle = 45f;
        flashlight.intensity = intensity;
        flashlight.enabled = true; // ó���� ���� ���·� ����
    }

    void Update()
    {
        // FŰ�� ������ �÷��ö���Ʈ �ѱ�/����
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }
    }
}
