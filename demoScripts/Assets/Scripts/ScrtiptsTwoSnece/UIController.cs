using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text _txtCount;
    public static int CountKiilEnemy { get; set; }

    private void Update()
    {
        _txtCount.text = CountKiilEnemy.ToString();
    }
}
