using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Импорт инфраструктуры для работы с кодом UI.

public class UIController : MonoBehaviour {
    // Объект сцены Reference Text, предназначенный для задания свойства text.
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private int _score;

//    Awake выполняется всегда перед стартом
    private void Awake() {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

//    выполняется, когда уничтожается объект
    private void OnDestroy() {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    void Start() {
        _score = 0;
        scoreLabel.text = _score.ToString();
//        Закрываем всплывающее окно в момент начала игры.
//        settingsPopup.Close();
    }

    // Update is called once per frame
//    void Update() {
//        scoreLabel.text = Time.realtimeSinceStartup.ToString();
//    }

    private void OnEnemyHit() {
        Debug.Log("OnEnemyHit");
        _score += 1;
        scoreLabel.text = _score.ToString();
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
