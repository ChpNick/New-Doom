﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    private int _health;

    // Use this for initialization
    void Start() {
        _health = 5; // Инициализация переменной health. 
    }

    public void Hurt(int damage) {
        _health -= damage; // Уменьшение здоровья игрока.
        Debug.Log("Health: " + _health);
    }
}