using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _text;


    public void OnEnable()
    {
        SpawnCube.AddCountCube += UpdateCountCube;
    }

    public void UpdateCountCube(int count)
    {
        _text.text = "Кол-во кубов на сцене: " + count;
    }
}
