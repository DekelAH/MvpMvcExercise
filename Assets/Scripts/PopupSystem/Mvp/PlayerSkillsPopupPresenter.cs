using Models;
using MvcMvpExample.Mvp;
using UnityEngine;

namespace Assets.Scripts.PopupSystem.Mvp
{
    public class PlayerSkillsPopupPresenter
    {
        private MvpPlayerSkillsPopupView _view;

        private PlayerSkillsModel _model;

        public PlayerSkillsPopupPresenter(MvpPlayerSkillsPopupView view, PlayerSkillsModel model)
        {
            _view = view;
            _model = model;

            Subscribe();
            UpdateView();
        }

        private void Subscribe()
        {
            _view.StrengthButtonClick += OnStrengthButtonClick;
            _view.IntelligenceButtonClick += OnIntelligenceButtonClick;
            _view.MagicButtonClick += OnMagicButtonClick;
            _view.SaveButtonClicked += OnSaveButtonClicked;

            _model.DataChanged += OnDataChanged;
            _model.PlayerLevelChanged += PlayerLevelChanged;
        }

        private void Unsubscribe()
        {
            _view.StrengthButtonClick -= OnStrengthButtonClick;
            _view.IntelligenceButtonClick -= OnIntelligenceButtonClick;
            _view.MagicButtonClick -= OnMagicButtonClick;
            _view.SaveButtonClicked -= OnSaveButtonClicked;

            _model.DataChanged -= OnDataChanged;
            _model.PlayerLevelChanged -= PlayerLevelChanged;
        }

        private void PlayerLevelChanged()
        {
            _view.Shake();
        }

        private void OnDataChanged()
        {
            UpdateView();
        }

        private void UpdateView()
        {
            _view.UpdateData(_model.Strength, _model.Intelligence, _model.Magic, _model.PlayerLevel);
        }

        private void OnSaveButtonClicked()
        {
            _model.Save();
            Unsubscribe();
            Object.Destroy(_view.gameObject);
        }

        private void OnMagicButtonClick(int increment)
        {
            var magic = _model.Magic + increment;
            magic = Mathf.Clamp(magic, 0, PlayerSkillsModel.MAX_MAGIC);
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
