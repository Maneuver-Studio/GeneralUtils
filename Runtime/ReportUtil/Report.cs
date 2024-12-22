using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maneuver.GeneralUtils.SceneUtil
{
    public class Report : MonoBehaviour
    {
        public int FPS { get; private set; }

        private void Update()
        {
            FPS = (int)(1f / Time.unscaledDeltaTime);
        }
    }
}
