
using Models;
using UnityEngine;

namespace Assets.Scripts.PopupSystem.Mvp
{
    public class MvpPopupSystem : PopupSystem
    {
        #region Editor

        private MvpPlayerSkillPopupFactory _factory;

        #endregion


        #region Methods

        private void Awake()
        {
            _factory = new MvpPlayerSkillPopupFactory(_playerSkillsPopupPrefabRef, _playerSkillsModel);
        }

        public override void ShowPlayerSkillsPopup()
        {
            _factory.Create(_parentTransform);
        }

        #endregion
    }
}
