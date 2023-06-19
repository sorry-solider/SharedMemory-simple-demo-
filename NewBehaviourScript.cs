using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 创建共享内存文件
    private MemoryMappedFile sharedMemory = MemoryMappedFile.CreateOrOpen("SharedMemory", 1024);
    // 获取共享内存文件的访问器
    private MemoryMappedViewAccessor accessor;

    public GameObject[] models; // 定义静态的模型数组

    private void Start()
    {
        accessor = sharedMemory.CreateViewAccessor();
        Debug.Log("等待Python程序发送数据...");

    }

    //

    private void Update()
    {
        // 从共享内存中读取数据
        int cmd = accessor.ReadInt32(0);

        

        // 根据读取到的数据做出相应的响应
        switch (cmd)
        {
            case 48:
                // 展示模型0
                Debug.Log("展示模型0");
                // 加载并显示模型0
                models[0].SetActive(true);
                models[1].SetActive(false);
                models[2].SetActive(false);
                models[3].SetActive(false);
                break;
            case 49:
                // 展示模型1
                Debug.Log("展示模型1");
                // 加载并显示模型1
                models[0].SetActive(false);
                models[1].SetActive(true);
                models[2].SetActive(false);
                models[3].SetActive(false);
                break;
            case 50:
                // 展示模型2
                Debug.Log("展示模型2");
                // 加载并显示模型2
                models[0].SetActive(false);
                models[1].SetActive(false);
                models[2].SetActive(true);
                models[3].SetActive(false);
                break;
            case 51:
                // 展示模型3
                Debug.Log("展示模型3");
                // 加载并显示模型3
                models[0].SetActive(false);
                models[1].SetActive(false);
                models[2].SetActive(false);
                models[3].SetActive(true);
                break;
            default:
                // 其他情况
                Debug.Log("未知命令：" + cmd);
                break;
        }

        // 延时一段时间，等待Python程序处理
        Thread.Sleep(2);
    }


}
