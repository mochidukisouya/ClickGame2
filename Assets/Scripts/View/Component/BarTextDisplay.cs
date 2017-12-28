﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Slider))]

public class BarTextDisplay : MonoBehaviour {
    private Slider slider;
    public Text labal;

    private void Awake() {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnValueChange);



    }

    private void OnValueChange(float val) {
        val = Mathf.FloorToInt(val);
        labal.text = val + "/" + slider.maxValue;

    }
}