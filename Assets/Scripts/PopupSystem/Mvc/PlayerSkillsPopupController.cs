using Models;
using MvcMvpExample;
using UnityEngine;

namespace Assets.Scripts.PopupSystem.Mvc
{
    public class PlayerSkillsPopupController
    {
        private readonly MvcPlayerSkillsPopupView _view;
        private readonly PlayerSkillsModel _model;

        public PlayerSkillsPopupController(MvcPlayerSkillsPopupView view, PlayerSkillsModel model)
        {
            _view = view;
            _model = model;

            _view.StrengthButtonClick += OnStrengthButtonClick;
            _view.IntelligenceButtonClick += OnIntelligenceButtonClick;
            _view.MagicButtonClick += OnMagicButtonClick;
            _view.SaveButtonClicked += OnSaveButtonClick;
        }

        private void OnSaveButtonClick()
        {
            _view.StrengthButtonClick -= OnStrengthButtonClick;
            _view.IntelligenceButtonClick -= OnIntelligenceButtonClick;
            _view.MagicButtonClick -= OnMagicButtonClick;
            _view.SaveButtonClicked -= OnSaveButtonClick;

            Object.Destroy(_view.gameObject);
        }

        private void OnMagicButtonClick(int increment)
        {
            var magic = _model.Magic + increment;
            magic = Mathf.Clamp(magic,0 , PlayerSkillsModel.MAX_MAGIC);
            _model.UpdateMagic(magic);
        }

        private void OnIntelligenceButtonClick(int increment)
        {
            var intelligence = _model.Intelligence + increment;
            intelligence = Mathf.Clamp(intelligence, 0, PlayerSkillsModel.MAX_INTELLIGENCE);
            _model.UpdateIntelligence(intelligence);
        }

        private void OnStrengthButtonClick(int increment)
        {
            var strength = _model.Strength + increment;
            strength = Mathf.Clamp(strength, 0, PlayerSkillsModel.MAX_STRENGTH);
            _model.UpdateStrength(strength);
        }
    }
}
