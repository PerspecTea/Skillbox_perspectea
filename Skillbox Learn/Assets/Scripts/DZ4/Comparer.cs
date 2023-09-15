using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comparer : MonoBehaviour
{
    [SerializeField] private InputField _inputA;
    [SerializeField] private InputField _inputB;
    [SerializeField] private Text _result;


    public void Compare() {
        int operandA = int.Parse(_inputA.text);
        int operandB = int.Parse(_inputB.text);
        if (operandA == operandB)
        {
            _result.text = "Equal";
        }
        else if (operandA > operandB)
        {

            _result.text = (operandA).ToString();
        }
        else if (operandA < operandB)
        {
            _result.text = (operandB).ToString();
        }
    }
}
