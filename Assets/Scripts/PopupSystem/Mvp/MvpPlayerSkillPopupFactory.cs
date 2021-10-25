using Models;
using MvcMvpExample.Mvp;
using UnityEngine;

namespace Assets.Scripts.PopupSystem.Mvp
{
    public class MvpPlayerSkillPopupFactory : PlayerSkillsPopupFactoryBase<MvpPopupSystem>
    {
        public MvpPlayerSkillPopupFactory(Object playerSkillsPopupPrefabRef, PlayerSkillsModel model) : base(playerSkillsPopupPrefabRef, model) { }

        public override void Create(RectTransform parentTransform)
        {
            var popupInstance = (GameObject)Object.Instantiate(_popupPrefabRef, parentTransform);
            var mvpView = popupInstance.GetComponent<MvpPlayerSkillsPopupView>();

            var presenter = new PlayerSkillsPopupPresenter(mvpView, _model);

        }
    }
}
