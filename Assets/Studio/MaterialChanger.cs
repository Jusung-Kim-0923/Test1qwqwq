using UdonSharp;
using UnityEngine;

public class MaterialChanger : UdonSharpBehaviour
{
    // Material을 변경할 대상 Renderer
    public Renderer targetRenderer;

    // 순서대로 변경할 Material 배열
    public Material[] materials;

    // 현재 적용된 Material의 인덱스
    private int currentIndex = 0;

    public override void Interact()
    {
        // 배열이 비어 있거나 대상 Renderer가 설정되지 않은 경우 중단
        if (materials == null || materials.Length == 0 || targetRenderer == null) return;

        // 다음 Material로 변경
        currentIndex = (currentIndex + 1) % materials.Length;
        targetRenderer.material = materials[currentIndex];
    }
}
