using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maneuver.GeneralUtils
{
    [CreateAssetMenu(menuName = "Maneuver/SO/Sprite Variable", fileName = "Sprite Variable")]
    public class SpriteVariable : ScriptableObject
    {
        [SerializeField]
        private Sprite _value;

        public Sprite Value => _value;
    }
}
