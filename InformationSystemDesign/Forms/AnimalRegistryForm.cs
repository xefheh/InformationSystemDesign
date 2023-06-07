﻿using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class AnimalRegistryForm : Form
    {
        private readonly IController<AnimalCard> _controller;
        private BindingList<AnimalCard> _sourceList;
        private BindingList<AnimalCard> _view;

        public AnimalRegistryForm(IController<AnimalCard> controller)
        {
            InitializeComponent();
            _controller = controller;
            _sourceList = _controller.GetCards();
            _view = _sourceList;
            _registryView.DataSource = _view;
            _registryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            var animalCardForm = new AnimalCardForm();
            if (animalCardForm.ShowDialog() != DialogResult.OK) return;
            try
            {
                _controller.AddCard(animalCardForm.GetAnimalCardParams());
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
        }

        private void _openButton_Click(object sender, EventArgs e)
        {
            if (_sourceList.Count == 0) return;
            var animalCard = GetCardFromSelectedRow();
            OpenCard(animalCard);
        }

        private void OpenCard(AnimalCard animalCard)
        {
            var animalCardForm = new AnimalCardForm(animalCard);
            var dialog = animalCardForm.ShowDialog();
            try
            {
                if (animalCardForm.DeleteAction) _controller.RemoveCard(animalCard);
                if (dialog != DialogResult.OK) return;
                _controller.UpdateCard(animalCard, animalCardForm.GetAnimalCardParams());
                UpdateDataSource();
            }
            catch (PermissionException)
            {
                ShowPermitMessage();
            }
        }

        private AnimalCard GetCardFromSelectedRow()
        {
            var id = (int)_registryView.CurrentRow.Cells[0].Value;
            return _controller.GetCard(id);
        }

        private void UpdateDataSource()
        {
            _registryView.DataSource = null;
            _registryView.DataSource = _view;
        }

        private void ShowPermitMessage() =>
            MessageBox.Show("Недостаточно прав для данного действия!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        private void _openByIdButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(_idBox.Text, out var id))
            {
                var animalCard = _controller.GetCard(id);
                if (animalCard != null)
                {
                    OpenCard(animalCard);
                    return;
                }
                MessageBox.Show("Карты с таким номером не существует!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Некоректный id!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void _inspectionButton_Click(object sender, EventArgs e)
        {
            if (_sourceList.Count == 0) return;
            var animalCard = GetCardFromSelectedRow();
            var inspectionCards =
                ((AnimalRegistryController)_controller).GetInspectionCardByAnimalId(animalCard.RegNumber);
            var inspectionForm = new InspectionForm(GetCardFromSelectedRow(), inspectionCards);
            inspectionForm.ShowDialog();
            ((AnimalRegistryController)_controller).InvokeStorageUpdating();
        }
    }
}