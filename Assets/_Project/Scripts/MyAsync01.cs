using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using DG.Tweening;

[ExecuteInEditMode]
public class MyAsync01 : MonoBehaviour
{
    async Task MySequence()
    {
        await MyTask01();
        //await MyTween01();
    }


    void OnEnable()
    {
        _ = MySequence();
    }


    Tween MyTween01()
    {
        return transform.DOScale(4, 2);
    }

    private async Task MyTask01()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
    }
}