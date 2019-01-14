using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Импорт инфраструктуры для работы с кодом UI.

public class UIController : MonoBehaviour {

    // Объект сцены Reference Text, предназначенный для задания свойства text.
    [SerializeField] private Text scoreLabel;

    // Update is called once per frame
    void Update() {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings() {
        // Метод, вызываемый кнопкой настроек.
        Debug.Log("open settings");
    }
    
    public void OnPointerDown() {
        Debug.Log("pointer down");
    }
}