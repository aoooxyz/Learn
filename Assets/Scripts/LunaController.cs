using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 120;  //设置游戏帧率为120
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");  //定义浮点数horizontal用于存储Input.GetAxis方法的返回值，控制左右
	    float vertical = Input.GetAxisRaw("Vertical");  //定义浮点数vertical用于存储Input.GetAxis方法的返回值，控制上下
        Vector3 position = transform.position;  //定义二维向量类型坐标posttion并赋值获取当前对象物体的位置
        position.x += 6*horizontal*Time.deltaTime;  //根据时间差和水平方向的输入，更新y坐标
        position.y += 6*vertical*Time.deltaTime;  //根据时间差和垂直方向的输入，更新x坐标
	    transform.position = position;  //把修改后的位置应用到对象物体上，实现移动效果
    }
}
