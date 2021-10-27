using Models;
using MvcMvpExample.Mvp;
using UnityEngine;

namespace Assets.Scripts.PopupSystem.Mvp
{
    public class MvpPlayerSkillPopupFactory : PlayerSkillsPopupFactoryBase
    {
        public MvpPlayerSkillPopupFactory(Object playerSkillsPopupPrefabRef, PlayerSkillsModel model) : base(playerSkillsPopupPrefabRef, model) { }

        protected override void LinkedComponents(GameObject popupInstance)
        {
            var mvpView = popupInstance.GetComponent<MvpPlayerSkillsPopupView>();

            var presenter = new PlayerSkillsPopupPresenter(mvpView, _model);
        }
    }
}
