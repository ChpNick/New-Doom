using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour {
    [SerializeField] private Slider speedSlider;

    void Start() {
        Close();
        speedSlider.value = PlayerPrefs.GetFloat("Speed", 1);
    }

    public void Open() {
//        Активируйте этот объект, чтобы открыть окно.
        gameObject.SetActive(true);
    }

    public void Close() {
//        Деактивируйте объект, чтобы закрыть окно.
        Debug.Log("Close");
        gameObject.SetActive(false);
    }

//    начала ввода данных в текстовое поле.
    public void OnSubmitName(string name) {
        Debug.Log(name);
    }

//    Этот метод срабатывает при изменении положения ползунка.
    public void OnSpeedValue(float speed) {
        Debug.Log("Speed UP: " + speed);
        PlayerPrefs.SetFloat("Speed", speed);

        Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
        
    }
}