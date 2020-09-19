using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CommonUI
{
    public class CommonPopup : MonoBehaviour
    {
        private Text m_TextTitle;
        private Text m_TextContent;
        private Button m_ButtonYes;
        private Text m_TextYes;
        private Button m_ButtonNo;
        private Text m_TextNo;

        private string m_Title;
        private string m_Content;
        private string m_Yes;
        private string m_No;

        private void Awake()
        {
            m_TextTitle = transform.Find("Text_Title").GetComponent<Text>();
            m_TextContent = transform.Find("Text_Content").GetComponent<Text>();
            m_ButtonYes = transform.Find("Button_Yes").GetComponent<Button>();
            m_TextYes = m_ButtonYes.transform.Find("Text").GetComponent<Text>();
            m_ButtonNo = transform.Find("Button_No").GetComponent<Button>();
            m_TextNo = m_ButtonNo.transform.Find("Text").GetComponent<Text>();

            m_ButtonYes.onClick.AddListener(OnClickYes);
            m_ButtonNo.onClick.AddListener(OnClickNo);
        }

        private void OnClickYes()
        {

        }

        private void OnClickNo()
        {
            Close();
        }

        private void Close()
        {
            Destroy(gameObject);
        }
    }
}