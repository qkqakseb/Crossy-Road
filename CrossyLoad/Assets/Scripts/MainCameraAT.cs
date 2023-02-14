using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAT : MonoBehaviour
{
    public GameObject Target; // ī�޶� ����ٴ� Ÿ��

    public float offsetX = default;  // offset : Ÿ�����κ����� ī�޶� ��ġ
    public float offsetY = default;
    public float offsetZ = default;

    public float cameraSpeed = 10f;
    Vector3 TargetPos;  // Ÿ�� ��ġ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = new Vector3(Target.transform.position.x + offsetX, Target.transform.position.y + offsetY, Target.transform.position.z + offsetZ);
        
        // ī�޶��� �������� �ε巴�� �ϴ� �Լ�(Lerp)
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * cameraSpeed);
    }
}
