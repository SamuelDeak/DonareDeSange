﻿using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogareMedic : Form
    {
        private UserMedicService serviceMedic;

        public FormLogareMedic(UserMedicService service)
        {
            InitializeComponent();
            serviceMedic = service;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username, parola;
            username = textBoxUsername.Text;
            parola = textBoxPassword.Text;

            if (username.Equals("") || username.Equals(""))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(this, "Trebuie sa completati ambele campuri", "Eroare!", buttons);
            }
            else
            {
                bool result = serviceMedic.Login(username, parola);
                if (result)
                {
                    Form formMainView = new FormMedic(serviceMedic);
                    this.Hide();
                    formMainView.Closed += (s, args) => this.Close();
                    formMainView.ShowDialog();
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(this, "Usernameul sau parola au fost introduse gresit!", "Eroare!", buttons);
                }
            }
        }

      
    }
}
