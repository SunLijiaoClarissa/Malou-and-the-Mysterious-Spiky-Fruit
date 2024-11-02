using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnClick : MonoBehaviour
{
    public float jumpForce = 5f; // 跳跃的力度
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // 获取刚体组件
        rb = GetComponent<Rigidbody>();

        // 确保物体有刚体
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 此处可以添加更新逻辑，若有需要
    }

    private void OnMouseDown()
    {
        // 物体被点击时向上施加力
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
