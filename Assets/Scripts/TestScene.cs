using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommonUI;

public class TestScene : MonoBehaviour
{
    private void Awake()
    {
        PopupManager.Instance.ShowCommonPopup("제목", "본문 블라블라", "예", "아니요",
            OnClickPopupYes, OnClickPopupNo);
    }

    private void OnClickPopupYes()
    {
        PopupManager.Instance.ShowToastPopup("예 버튼을 클릭하였습니다.");
    }

    private void OnClickPopupNo()
    {
        Debug.Log("아니요 버튼을 클릭하였습니다.");
    }
}