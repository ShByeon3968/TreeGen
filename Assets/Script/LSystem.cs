using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSystem
{
    // Ʈ���� ȸ�� �б� ���� ����
    //���⼭ axiom�� ���� ��Ģ(��: "F"), rules�� ���ڿ� �׿� ���� ��ȯ ��Ģ�� ��Ÿ��
    // ���� ���, rules['F'] = "F[+F][-F]"�� ���� ������ �� ����
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
