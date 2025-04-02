using UnityEngine;

namespace Maneuver.GeneralUtils.FPSCounter
{
    public class FPS : MonoBehaviour
    {
        public FPSBuffer FPSBuffer { get; private set; }

        [SerializeField, Range(15, 300), FormerlySerializedAs("bufferSize")]
        int _bufferSize = 60;

        void OnEnable() => FPSBuffer = new FPSBuffer(_bufferSize);

        void Update() => FPSBuffer.UpdateBuffer();
    }
}