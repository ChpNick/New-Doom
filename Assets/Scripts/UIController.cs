using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Импорт инфраструктуры для работы с кодом UI.

public class UIController : MonoBehaviour {

    // Объект сцены Reference Text, предназначенный для задания свойства text.
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;
    
    void Start() {
//        Закрываем всплывающее окно в момент начала игры.
        settingsPopup.Close();
        
    }

    // Update is called once per frame
    void Update() {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings() {
        // Метод, вызываемый кнопкой настроек.
        Debug.Log("open settings");
//        Заменяем отладочный текст методом всплывающего окна.
        settingsPopup.Open(); 
    }
    
    public void OnPointerDown() {
        Debug.Log("pointer down");
    }
}