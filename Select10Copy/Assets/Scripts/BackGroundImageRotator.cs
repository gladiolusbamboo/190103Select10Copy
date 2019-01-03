using UnityEngine;
using DG.Tweening;
using Coffee.UIExtensions;

public class BackGroundImageRotator : MonoBehaviour {
    public UIGradient uiGradient;

    // Use this for initialization
    void Start () {
        // Rotationを-180→180へ変化させる
        uiGradient.rotation = -180;
        DOTween.To(
            // どの値を変更するか
            () => uiGradient.rotation,
            // どう変更するか
            (val) => uiGradient.rotation = val,
            // 180まで変更させる
            180,
            // 2sで変更させる
            2.0f
        // ずっとループさせる
        ).SetLoops(-1, LoopType.Restart);
    }
}
