﻿/*
    Copyright (c) 2015 Jeffrey Quesnelle

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;

namespace MissionControl.Input
{
    class BaseObjectInput : BaseInput
    {
        private int value;
        private bool reset;
        protected InputProperties properties;

        public override event InputManager.InputChangedHandler InputChanged;

        protected void OnNewValue(int newValue)
        {
            int oldValue = value;
            value = newValue;
            if ((oldValue != newValue) && (InputChanged != null))
                InputChanged(this, oldValue, newValue);
        }

        public InputProperties Properties
        {
            get { return properties; }
        }

        public BaseObjectInput(InputProperties p, bool reset)
        {
            properties = p;
            this.reset = reset;
            value = 0;
        }

        public override int Value
        {
            get { return value; }
        }
        internal override void ProcessData(IConnectedDevice device, int incomingValue, int offset)
        {
            OnNewValue(incomingValue);
        }

        internal override void BeforeProcess()
        {
            if (reset)
                value = 0;
        }
    }
}
