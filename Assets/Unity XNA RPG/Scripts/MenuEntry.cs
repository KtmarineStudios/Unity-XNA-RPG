using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuEntry : MonoBehaviour, IPointerEnterHandler, ISelectHandler, IPointerExitHandler
{
    /// <summary>
    /// The normal color of the text;
    /// </summary>
    [SerializeField]
    private Color32 m_normalColor = new Color32(59, 18, 6, 255);

    /// <summary>
    /// The normal color of the text;
    /// </summary>
    [SerializeField]
    private Color32 m_selectedColor = new Color32(248, 218, 127, 255);

    /// <summary>
    /// The normal color of the text;
    /// </summary>
    [SerializeField]
    private Color32 m_highlightColor = new Color32(223, 206, 148, 255);
    
    /// <summary>
    /// The Text Displayed on the Button.
    /// </summary>
    [SerializeField]
    private Text m_buttonText;

    /// <summary>
    /// The Text Displayed on the Button.
    /// </summary>
    [SerializeField]
    private Button m_button;

    [SerializeField]
    private string m_description = "";


    // Update is called once per frame
    void Update()
    {
        if(EventSystem.current?.currentSelectedGameObject == gameObject)
            m_buttonText.color = m_selectedColor;
        else
            m_buttonText.color = m_normalColor;
        
    }


    public void OnPointerEnter(PointerEventData eventData) => m_buttonText.color = m_highlightColor;
      public void OnSelect(BaseEventData eventData)=> m_buttonText.color = m_selectedColor;

    public void OnPointerExit(PointerEventData eventData) => m_buttonText.color = m_normalColor;
}
