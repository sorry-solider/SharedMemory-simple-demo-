using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // ���������ڴ��ļ�
    private MemoryMappedFile sharedMemory = MemoryMappedFile.CreateOrOpen("SharedMemory", 1024);
    // ��ȡ�����ڴ��ļ��ķ�����
    private MemoryMappedViewAccessor accessor;

    public GameObject[] models; // ���徲̬��ģ������

    private void Start()
    {
        accessor = sharedMemory.CreateViewAccessor();
        Debug.Log("�ȴ�Python����������...");

    }

    //

    private void Update()
    {
        // �ӹ����ڴ��ж�ȡ����
        int cmd = accessor.ReadInt32(0);

        

        // ���ݶ�ȡ��������������Ӧ����Ӧ
        switch (cmd)
        {
            case 48:
                // չʾģ��0
                Debug.Log("չʾģ��0");
                // ���ز���ʾģ��0
                models[0].SetActive(true);
                models[1].SetActive(false);
                models[2].SetActive(false);
                models[3].SetActive(false);
                break;
            case 49:
                // չʾģ��1
                Debug.Log("չʾģ��1");
                // ���ز���ʾģ��1
                models[0].SetActive(false);
                models[1].SetActive(true);
                models[2].SetActive(false);
                models[3].SetActive(false);
                break;
            case 50:
                // չʾģ��2
                Debug.Log("չʾģ��2");
                // ���ز���ʾģ��2
                models[0].SetActive(false);
                models[1].SetActive(false);
                models[2].SetActive(true);
                models[3].SetActive(false);
                break;
            case 51:
                // չʾģ��3
                Debug.Log("չʾģ��3");
                // ���ز���ʾģ��3
                models[0].SetActive(false);
                models[1].SetActive(false);
                models[2].SetActive(false);
                models[3].SetActive(true);
                break;
            default:
                // �������
                Debug.Log("δ֪���" + cmd);
                break;
        }

        // ��ʱһ��ʱ�䣬�ȴ�Python������
        Thread.Sleep(2);
    }


}
