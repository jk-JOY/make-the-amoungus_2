using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CreateRoomUI : MonoBehaviour
{


    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void CreateRoom()
    {  // ForUsRoomManager.singleton�� ���� �ִ� network�Ŵ����� ������,
        //StartHost �Լ� ȣ��  == startHOST�� ������ ���� ���ÿ�
        //Ŭ���̾�Ʈ�ν� ���ӿ� �����ϰ� ����� �Լ�
        var manager = ForUsRoomManager.singleton;

        //�� ���� �۾� ó��
        manager.StartHost();
    }
}
