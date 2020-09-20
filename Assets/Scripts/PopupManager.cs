using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace CommonUI
{
    public class PopupManager : Singleton<PopupManager>
    {
        [SerializeField] private Transform m_ParentCanvas;
        [SerializeField] private GameObject m_CommonPopupPrefab;

        private CommonPopup m_CommonPopup;

        public CommonPopup ShowCommonPopup(string title, string content, string yes, string no,
            CommonPopup.ClickYes clickYes, CommonPopup.ClickNo clickNo)
        {
            GameObject newObj = Instantiate(m_CommonPopupPrefab) as GameObject;
            newObj.transform.SetParent(m_ParentCanvas);
            RectTransform rt = newObj.transform as RectTransform;
            rt.anchoredPosition = Vector3.zero;

            m_CommonPopup = newObj.GetComponent<CommonPopup>();
            m_CommonPopup.Setup(title, content, yes, no);
            m_CommonPopup.SetCallback(clickYes, clickNo);
            
            return m_CommonPopup;
        }

        public void CloseCommonPopup()
        {
            Destroy(m_CommonPopup.gameObject);
        }
    }
}