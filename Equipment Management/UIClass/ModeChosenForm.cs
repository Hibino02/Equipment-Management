﻿using System;
using System.Windows.Forms;

namespace Equipment_Management.UIClass
{
    public partial class ModeChosenForm : Form
    {
        private MainBackGroundFrom _mainBackgroundForm;
        public event EventHandler OnEquipmentControlRequested;

        public ModeChosenForm(MainBackGroundFrom mainBackGroundForm)
        {
            InitializeComponent();
            _mainBackgroundForm = mainBackGroundForm;
        }

        //Click event to call
        private void equipmentControlButton_Click(object sender, EventArgs e)
        {
            _mainBackgroundForm.Enabled = true;
            OnEquipmentControlRequested?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void ModeChosenForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
