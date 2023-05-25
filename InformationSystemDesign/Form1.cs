using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign
{
    public partial class Form1 : Form
    {

        public Form1() => InitializeComponent();

        private void _animalRegistryButton_Click(object sender, EventArgs e) =>
            Program.AnimalRegistryForm.ShowDialog();

        private void _municipalRegistryButton_Click(object sender, EventArgs e) =>
            Program.MunicipalRegistryForm.ShowDialog();

        private void _organizationRegistryButton_Click(object sender, EventArgs e) =>
            Program.OrganizationRegistryForm.ShowDialog();
    }
}