using Models;
using UnityEngine;

namespace Assets.Scripts.PopupSystem
{
    public abstract class PopupSystem : MonoBehaviour
    {
        [SerializeField]
        protected RectTransform _parentTransform;

        [SerializeField]
        protected Object _playerSkillsPopupPrefabRef;

        [SerializeField]
        protected PlayerSkillsModel _playerSkillsModel;

        public abstract void ShowPlayerSkillsPopup();



    }
}
