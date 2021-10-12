using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoomUI : MonoBehaviour
{
    [SerializeField]
    private List<Image> crewImgs; //이미지를 담는 리스트

    [SerializeField]
    private List<Button> kingCountButtons; //왕 숫자 버튼

    [SerializeField]
    private List<Button> imposterCountButtons; //간신 숫자 버튼

    [SerializeField]
    private List<Button> maxPlayerCountButtons; // 플레이어 최대 버튼

    private CreateGameRoomData roomData;  //룸데이터 

    void Start()
    { 
        
    //
    //    for (int i = 0; i < crewImgs.Count; i++)
    //    {
    //        Material materialTnstance = Instantiate(crewImgs[i].material);
    //        crewImgs[i].material = materialTnstance;
    //    }
        
        // 룸데이터 의 값에 (왕1 간신1 맥스6) 하고 UpdateCrewImages함수 실행
        roomData = new CreateGameRoomData() { kingCount = 1, imposterCount = 1, maxPlayerCount = 10 };
        UpdateCrewImages();
    }
       
    private void UpdateCrewImages()  //임포스터와 플레이어 수에 따라 바뀌는 함수 
    { //수가 0이 될때까지 플레이어를 뽑아 RED로 만들어줌.   -- 임포스터 수 표현
        int imposterCount = roomData.imposterCount;
        int idx = 0;
        while (imposterCount != 0)
        {
            if (idx >= roomData.maxPlayerCount)
            {
                idx = 0;
            }

            // Debug.Log("About to set the color", gameObject);

            if (crewImgs[idx].material.GetColor("_PlayerColor") != Color.red && Random.Range(0, 6) == 0)
            {
                crewImgs[idx].material.SetColor("_PlayerColor", Color.red);
                imposterCount--;
            }
            idx++;
        }

        for (int i = 0; i < crewImgs.Count; i++)  //설정한 크루원들만 이미지 활성, 나머지는 비활성
        {
            if(i < roomData.maxPlayerCount)
            {
                crewImgs[i].gameObject.SetActive(true);
            }
            else
            {
                crewImgs[i].gameObject.SetActive(false);
            }
        }
    }
}

public class CreateGameRoomData
{
    public int kingCount;
    public int imposterCount;
    public int maxPlayerCount;
    
}