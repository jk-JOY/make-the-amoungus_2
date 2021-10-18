using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class OnlineUI : MonoBehaviour
{
    [SerializeField]
    private InputField nicknameInputField;

    [SerializeField]
    private GameObject createRoomUI;



    //룸만드는 버튼 이름 입력하였는지, 확인하는 애니매이션 효과.
    public void OnClickCreateRoomButton()
    {
        if(nicknameInputField.text != "")
        {
            CommonSettings.nickname = nicknameInputField.text;
            createRoomUI.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            nicknameInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }

    // ForUsRoomManager로 룸매니저를 찾아 싱글톤으로 연결
    public void OnClickEnterGameRoomButton()
    {
        var manager = ForUsRoomManager.singleton;
        manager.StartClient();
    }
}