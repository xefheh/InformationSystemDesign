using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Initialization;

namespace InformationSystemDesign.Forms
{
    public partial class AuthorizationForm : Form
    {
        private readonly UserInformer _userInformer;
        public AuthorizationForm(UserInformer userInformer)
        {
            InitializeComponent();
            _userInformer = userInformer;
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                _userInformer.Enter(textBox1.Text, textBox2.Text);
            }
            catch (InvalidLoginException)
            {
                MessageBox.Show("Не существующий логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadMainForm(_userInformer.Enter(textBox1.Text, textBox2.Text));
        }

        private void LoadMainForm(User user)
        {
            Hide();
            Program.CreateMainFormInitializer(user).OpenMainForm();
        }
    }
}
