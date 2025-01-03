﻿using DeathCounterHotkey.Controller.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathCounterHotkey.Forms
{
    public partial class AddLocation : Form
    {
        private Action<string> _action;
        private LocationController _controller;

        public AddLocation(LocationController controller, Action<string> updateListAction)
        {
            InitializeComponent();
            this._action = updateListAction;
            this._controller = controller;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string locationName = locationNameTxtb.Text.Trim();
            if (this._controller.AddLocation(locationName))
            {
                _action?.Invoke(locationName);
                this.Close();
            }
            else
            {
                //Todo Message of double Entry
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
