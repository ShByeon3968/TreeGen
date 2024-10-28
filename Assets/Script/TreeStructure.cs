using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeNode
{
    public Vector3 Position;
    public Vector3 Direction;
    public float Length;

    public TreeNode(Vector3 position, Vector3 direction, float length)
    {
        Position = position;
        Direction = direction;
        Length = length;
    }
}


public class TreeStructure : MonoBehaviour
{
    // 생성된 L 시스템 문자열을 기반으로 트리 데이터 구성
    public List<TreeNode> Nodes = new List<TreeNode>();

    public void AddNode(TreeNode node)
    {
        Nodes.Add(node);
    }
   
}
