using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField _inputA;
    [SerializeField] private InputField _inputB;
    [SerializeField] private Text _result;
    int operandA;
    int operandB;


    public void InputCheck()
    {
        operandA = int.Parse(_inputA.text);
        operandB = int.Parse(_inputB.text);
    }
    public void Addiction()
    {
        _result.text = (operandA + operandB).ToString();
    }
    public void Substract()
    {
        _result.text = (operandA - operandB).ToString();
    }
    public void Multply()
    {
        _result.text = (operandA * operandB).ToString();
    }
    public void Divide()
    {
        if (operandB == 0)
        {
            _result.text = "!Divide by 0!";
            return;
        }
        _result.text = (operandA / operandB).ToString();
    }
}
