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



    //�븸��� ��ư �̸� �Է��Ͽ�����, Ȯ���ϴ� �ִϸ��̼� ȿ��.
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

    // ForUsRoomManager�� ��Ŵ����� ã�� �̱������� ����
    public void OnClickEnterGameRoomButton()
    {
        var manager = ForUsRoomManager.singleton;
        manager.StartClient();
    }
}