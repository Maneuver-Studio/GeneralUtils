using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Maneuver.GeneralUtils
{
    [CreateAssetMenu(menuName = "Maneuver/SO/AssetReferenceSprite Variable", fileName = "AssetReferenceSprite Variable")]
    public class AssetReferenceSpriteVariable : ScriptableObject
    {
        [SerializeField]
        private AssetReferenceSprite _value;

        public AssetReferenceSprite Value => _value;

        public async UniTask<Sprite> GetSpriteAsync()
        {
            var handle = _value.LoadAssetAsync();
            await handle;

            return handle.Result;
        }
    }
}
