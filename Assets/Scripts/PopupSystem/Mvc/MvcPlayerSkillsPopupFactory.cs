
using Assets.Scripts.PopupSystem.Mvc;
using Models;
using MvcMvpExample;
using UnityEngine;

namespace Assets.Scripts.PopupSystem
{
    public class MvcPlayerSkillsPopupFactory : PlayerSkillsPopupFactoryBase<MvcPopupSystem>
    {
        public MvcPlayerSkillsPopupFactory(Object playerSkillsPopupPrefabRef, PlayerSkillsModel model) : base(playerSkillsPopupPrefabRef, model) { }

        public override void Create(RectTransform parentTransform)
        {
            var popupInstance = (GameObject)Object.Instantiate(_popupPrefabRef, parentTransform);
            var mvcView = popupInstance.GetComponent<MvcPlayerSkillsPopupView>();

            var controller = new PlayerSkillsPopupController(mvcView, _model);

            mvcView.SetModel(_model);
        }
    }
}
