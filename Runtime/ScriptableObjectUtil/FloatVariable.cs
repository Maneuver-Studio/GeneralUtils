using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maneuver.GeneralUtils
{
    [CreateAssetMenu(menuName = "Maneuver/SO/Float Variable", fileName = "Float Variable")]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField]
        private float _value;

        public float Value => _value;

    }
}
