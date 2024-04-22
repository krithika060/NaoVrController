using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Scripting.Python;

public class NaoControl : MonoBehaviour
{
    Vector3 startPos_Nao;
    public Transform transform_nao;

    // Start is called before the first frame update
    void Start()
    {
        startPos_Nao = transform_nao.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveForwardBack();
        MoveLeftRight();
        MoveRotate();
        
    }

    void MoveLeftRight()
    {
        Vector3 vec_left = Vector3.zero;
        vec_left.x = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(vec_left.x, 0.0f, 0.0f) * Time.deltaTime * 15.0f;
        transform_nao.Translate(v, Space.Self);
    }

    void MoveForwardBack()
    {
        Vector3 vec_forward = Vector3.zero;
        vec_forward.z = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(0.0f, 0.0f, vec_forward.z) * Time.deltaTime * 15.0f;
        transform_nao.Translate(v, Space.Self);
    }

    void MoveRotate()
    {
        Vector3 vec_rotate = Vector3.zero;
        vec_rotate.y = Input.GetAxis("Rotate");
        Vector3 v = new Vector3(0.0f, vec_rotate.y, 0.0f) * Time.deltaTime * 15.0f;
        transform_nao.Rotate(v, Space.Self);
    }
}
