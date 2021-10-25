using Models;
using UnityEngine;

namespace Assets.Scripts.PopupSystem
{
    public class MvcPopupSystem : PopupSystem
    {
        #region Editor

        private MvcPlayerSkillsPopupFactory _factory;

        #endregion


        #region Methods

        private void Awake()
        {
            _factory = new MvcPlayerSkillsPopupFactory(_playerSkillsPopupPrefabRef, _playerSkillsModel);
        }

        public override void ShowPlayerSkillsPopup()
        {
            _factory.Create(_parentTransform);
        }

        #endregion
    }
}
