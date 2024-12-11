using UdonSharp;
using UnityEngine;

public class MaterialChanger : UdonSharpBehaviour
{
    // Material�� ������ ��� Renderer
    public Renderer targetRenderer;

    // ������� ������ Material �迭
    public Material[] materials;

    // ���� ����� Material�� �ε���
    private int currentIndex = 0;

    public override void Interact()
    {
        // �迭�� ��� �ְų� ��� Renderer�� �������� ���� ��� �ߴ�
        if (materials == null || materials.Length == 0 || targetRenderer == null) return;

        // ���� Material�� ����
        currentIndex = (currentIndex + 1) % materials.Length;
        targetRenderer.material = materials[currentIndex];
    }
}
