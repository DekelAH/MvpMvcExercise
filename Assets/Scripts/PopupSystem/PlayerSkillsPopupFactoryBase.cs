using Models;
using UnityEngine;

namespace Assets.Scripts.PopupSystem
{
    public abstract class PlayerSkillsPopupFactoryBase<T>
        where T : new()
    {
        protected Object _popupPrefabRef;
        protected PlayerSkillsModel _model;

        public PlayerSkillsPopupFactoryBase(Object playerSkillsPopupPrefabRef, PlayerSkillsModel model)
        {
            _popupPrefabRef = playerSkillsPopupPrefabRef;
            _model = model;
        }

        public abstract void Create(RectTransform parentTransform);
    }
}
