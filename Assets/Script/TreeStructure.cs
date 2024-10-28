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
    // ������ L �ý��� ���ڿ��� ������� Ʈ�� ������ ����
    public List<TreeNode> Nodes = new List<TreeNode>();

    public void AddNode(TreeNode node)
    {
        Nodes.Add(node);
    }
   
}
