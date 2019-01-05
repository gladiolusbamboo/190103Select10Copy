using System.Collections;
using UnityEngine;
using DG.Tweening;
using System;

public class TitleDisplayer : MonoBehaviour
{
    public CanvasGroup titleLogoCanvas;

    // Start is called before the first frame update
    void Start()
    {
        // 表示が気持ち悪かったので0.1s待つ
        StartCoroutine(DelayMethod(0.1f, () =>
        {
            titleLogoCanvas.DOFade(0.7f, 1.0f).SetEase(Ease.OutSine);
        }));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DelayMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }
}
