﻿using Arduino.Selfienator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arduino.Selfienator.ViewModels
{
    public class CommandPropertyHelper:ViewModel
    {
        private int _angle;
        private int _direction;
        private int _delay;

        public int angle
        {
            get { return _angle; }
            set
            {
                _angle = value;
                NotifyPropertyChanged();
            }
        }
        public int direction
        {
            get { return _direction; }
            set
            {
                _direction = value;
                NotifyPropertyChanged();
            }
        }
        public int delay
        {
            get { return _delay; }
            set
            {
                _delay = value;
                NotifyPropertyChanged();
            }
        }
    }
}
