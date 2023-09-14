using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField _inputA;
    [SerializeField] private InputField _inputB;
    [SerializeField] private Text _result;


    public void Addiction()
    {
        int operandA = int.Parse(_inputA.text);
        int operandB = int.Parse(_inputB.text);
        _result.text = (operandA + operandB).ToString();
    }
    public void Substract()
    {
        int operandA = int.Parse(_inputA.text);
        int operandB = int.Parse(_inputB.text);
        _result.text = (operandA - operandB).ToString();
    }
    public void Multply()
    {
        int operandA = int.Parse(_inputA.text);
        int operandB = int.Parse(_inputB.text);
        _result.text = (operandA * operandB).ToString();
    }
    public void Divide()
    {
        int operandA = int.Parse(_inputA.text);
        int operandB = int.Parse(_inputB.text);
        if (operandB == 0)
        {
            _result.text = "!Divide by 0!";
            return;
        }
        _result.text = (operandA / operandB).ToString();
    }
}
