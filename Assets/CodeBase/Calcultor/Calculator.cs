using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private float _numOne;
    [SerializeField] private float _numTwo;
    [SerializeField] private string _operation;


    private void Start()
    {
        MakeCalculate();
    }
    private void MakeCalculate()
    {
        switch (_operation)
        {
            case "+" :
                var result = _numOne + _numTwo;
                Debug.Log(result);
                break; 

            case "-" :
                result = _numOne - _numTwo;
                Debug.Log(result);
                break;

            case "*" :
                result = _numOne * _numTwo;
                Debug.Log(result);
                break;

            case "/" :
                if (_numTwo != 0)
                {
                    result = _numOne / _numTwo;
                    Debug.Log(result);
                }
                else
                {
                    Debug.Log("На ноль делить нельзя");
                }
                break;

            default:
                Debug.Log("Операция отсутствует");
                break;

        }
    }
}