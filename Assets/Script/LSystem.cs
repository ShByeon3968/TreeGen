using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSystem
{
    // 트리의 회전 분기 패턴 정의
    //여기서 axiom은 시작 규칙(예: "F"), rules는 문자와 그에 대한 변환 규칙을 나타냄
    // 예를 들어, rules['F'] = "F[+F][-F]"와 같이 설정할 수 있음
    public string GenerateTree(int iteration, string axiom, Dictionary<char, string> rules)
    {
        string current = axiom;
        for (int i = 0; i<iteration; i++)
        {
            string next = "";
            foreach(char c in current)
            {
                next += rules.ContainsKey(c) ? rules[c] : c.ToString();
            }
        }
        return current;

    }
}
