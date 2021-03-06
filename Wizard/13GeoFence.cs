﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArdupilotMega.Controls;
using ArdupilotMega.Controls.BackstageView;

namespace ArdupilotMega.Wizard
{
    public partial class _13GeoFence : MyUserControl, IWizard, IDeactivate, IActivate
    {

        public _13GeoFence()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (Wizard.config["fwtype"].ToString() == "copter")
            {
                configAC_Fence1.Activate();
            }
            else
            {
                // no sonar - keep going
                Wizard.instance.BeginInvoke((MethodInvoker)delegate
                {
                    Wizard.instance.GoNext(1, false);
                });
            }
        }

        public void Deactivate()
        {

        }

        public int WizardValidate()
        {
            return 1;
        }

    }
}
