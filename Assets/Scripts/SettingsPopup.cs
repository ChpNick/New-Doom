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
}
