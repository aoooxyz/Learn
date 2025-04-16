using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");  //定义浮点数moveX用于存储Input.GetAxis方法的返回值，控制左右
	    float moveY = Input.GetAxisRaw("Vertical");
        Vector3 position = transform.position;  //定义二维向量类型坐标posttion并赋值获取当前对象物体的位置
	    Vector3 forward = transform.forward;  //定义二维向量类型forward并赋值获取当前对象物体的朝向
        position.y += moveY * speed * Time.deltaTime;  //计算垂直位移量:方向*速度*每帧耗时，使用Time.deltaTime实现帧率无关的平滑移动
        position.x += moveX * speed * Time.deltaTime;  //计算水平位移量:方向*速度*每帧耗时，使用Time.deltaTime实现帧率无关的平滑移动
	    transform.position = position;  //把修改后的位置应用到对象物体上，实现移动效果
        transform.forward = forward;  //把修改后的位置应用到对象物体上，实现移动效果
    }
}
