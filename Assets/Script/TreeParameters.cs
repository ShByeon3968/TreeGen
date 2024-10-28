using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeParameters
{
    public int Iterations = 5; // L-System 반복 횟수
    public float Angle = 25f; // 각도 (도 단위)
    public float Length = 1f; // 초기 가지 길이
    public float LengthDecrease = 0.7f; // 가지 길이 감소율
    public int BranchesPerNode = 2; // 노드당 가지 개수
}