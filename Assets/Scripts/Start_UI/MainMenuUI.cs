using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���θ޴��� git�������� �ּ� �Ϸ�.
/// 
/// </summary>
public class MainMenuUI : MonoBehaviour  //onClickOnlineButton�Լ��� �����
{
    public void OnClickOnlineButton()
    {
        Debug.Log("Click Online");
    }
    public void OnclickQuitButton() //�����Ϳ��� ����� ���¶�� �÷��̸� �ߴܽ�Ű��
    {   //����� ���¶�� ���ø����̼��� �����ϵ���.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
