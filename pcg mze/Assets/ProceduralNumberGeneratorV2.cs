using UnityEngine;
using System.Collections;
using MiscUtil;

private void ProceduralNumberGenV2(int stringLength = 50)
{
    int _stringLength = stringLength - 1;
    string seed = "";
    string[] numbers  new string[] { "1", "2", "3", "4" };
    for (int i = 0; i <= stringLength; i++)
    {
        seed = seed + numbers[Random.Range(0, numbers.Length)];
    }
    return seed;
}
