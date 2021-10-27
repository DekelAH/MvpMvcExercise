using Models;
using UnityEngine;

namespace Assets.Scripts.PopupSystem
{
    public abstract class PlayerSkillsPopupFactoryBase
    {
        protected Object _popupPrefabRef;
        protected PlayerSkillsModel _model;

        public PlayerSkillsPopupFactoryBase(Object playerSkillsPopupPrefabRef, PlayerSkillsModel model)
        {
            _popupPrefabRef = playerSkillsPopupPrefabRef;
            _model = model;
        }

        public void Create(RectTransform parentTransform)
        {
            var popupInstance = (GameObject)Object.Instantiate(_popupPrefabRef, parentTransform);
            LinkedComponents(popupInstance);
        }

        protected abstract void LinkedComponents(GameObject popupInstance);
    }
}
