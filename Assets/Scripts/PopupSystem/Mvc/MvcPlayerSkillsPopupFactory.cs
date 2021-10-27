
using Assets.Scripts.PopupSystem.Mvc;
using Models;
using MvcMvpExample;
using UnityEngine;

namespace Assets.Scripts.PopupSystem
{
    public class MvcPlayerSkillsPopupFactory : PlayerSkillsPopupFactoryBase
    {
        public MvcPlayerSkillsPopupFactory(Object playerSkillsPopupPrefabRef, PlayerSkillsModel model) : base(playerSkillsPopupPrefabRef, model) { }

        protected override void LinkedComponents(GameObject popupInstance)
        {
            var mvcView = popupInstance.GetComponent<MvcPlayerSkillsPopupView>();
            mvcView.SetModel(_model);

            var controller = new PlayerSkillsPopupController(mvcView, _model);
        }
    }
}
