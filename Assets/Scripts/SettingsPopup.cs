using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopup : MonoBehaviour {
    public void Open() {
//        Активируйте этот объект, чтобы открыть окно.
        gameObject.SetActive(true);
    }

    public void Close() {
//        Деактивируйте объект, чтобы закрыть окно.
        gameObject.SetActive(false);
    }

//    начала ввода данных в текстовое поле.
    public void OnSubmitName(string name) {
        Debug.Log(name);
    }

//    Этот метод срабатывает при изменении положения ползунка.
    public void OnSpeedValue(float speed) {
        Debug.Log("Speed: " + speed);
    }
}