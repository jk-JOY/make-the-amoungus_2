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
    {  // ForUsRoomManager.singleton로 씬에 있는 network매니저를 가져와,
        //StartHost 함수 호출  == startHOST는 서버를 엶과 동시에
        //클라이언트로써 게임에 참가하게 만드는 함수
        var manager = ForUsRoomManager.singleton;

        //방 설정 작업 처리
        manager.StartHost();
    }
}
