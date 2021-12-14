using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Profiling;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text fpsDisplay;
    ProfilerRecorder totalUsedMemoryRecorder;

    void OnEnable()
    {
        Application.targetFrameRate = 90;
        totalUsedMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "Total Used Memory");
    }

    void OnDisable()
    {
        totalUsedMemoryRecorder.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        float fps = 1 / Time.unscaledDeltaTime;
        fpsDisplay.text = "FPS:" + fps + "\n" + $"Total Used Memory: {totalUsedMemoryRecorder.LastValue}";
    }
}
