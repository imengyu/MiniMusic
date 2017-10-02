using System;
using System.Collections.Generic;
using System.Drawing;
using LayeredSkin.DirectUI;

namespace MusicPlayer.MyLayeredSkin
{
    public class DuiCheckButton : DuiBaseControl
    {
        DuiButton buttonbase = new DuiButton();
        public DuiCheckButton()
        {
            base.Size = new Size(34, 34);
            buttonbase.Location = new Point();
            buttonbase.Size = base.Size;
            buttonbase.MouseClick += Buttonbase_MouseClick;
            base.Controls.Add(buttonbase);
        }

        private void Buttonbase_MouseClick(object sender, DuiMouseEventArgs e)
        {
            if(_ChengeOnClick)
            {
                if (Checked)
                    Checked = false;
                else
                    Checked = true;
            }
        }

        private bool _ChengeOnClick = false;
        private bool _Checked = false;
        private Image _CheckedNorImg = null;
        private Image _CheckedHovImg = null;
        private Image _CheckedPreImg = null;
        private Image _UnCheckedNorImg = null;
        private Image _UnCheckedHovImg = null;
        private Image _UnCheckedPreImg = null;

        public bool CheckOnClick
        {
            get { return _ChengeOnClick; }
            set { _ChengeOnClick = value; }
        }
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                _Checked = value;
                if(value)
                {
                    buttonbase.NormalImage = _CheckedNorImg;
                    buttonbase.HoverImage = _CheckedHovImg;
                    buttonbase.PressedImage = _CheckedPreImg;
                }
                else
                {
                    buttonbase.NormalImage = _UnCheckedNorImg;
                    buttonbase.HoverImage = _UnCheckedHovImg;
                    buttonbase.PressedImage = _UnCheckedPreImg;
                }
            }
        }
        public Image UnCheckedPreImg
        {
            get { return _UnCheckedPreImg; }
            set
            {
                _UnCheckedPreImg = value;
                if(!_Checked)
                    buttonbase.PressedImage = _UnCheckedPreImg;
            }
        }
        public Image UnCheckedHovImg
        {
            get { return _UnCheckedHovImg; }
            set
            {
                _UnCheckedHovImg = value;
                if (!_Checked)
                    buttonbase.HoverImage = _UnCheckedHovImg;
            }
        }
        public Image UnCheckedNorImg
        {
            get { return _UnCheckedNorImg; }
            set
            {
                _UnCheckedNorImg = value;
                if (!_Checked)
                    buttonbase.NormalImage = _UnCheckedNorImg;
            }
        }
        public Image CheckedPreImg
        {
            get { return _CheckedPreImg; }
            set { _CheckedPreImg = value; buttonbase.PressedImage = _CheckedPreImg; }
        }
        public Image CheckedHovImg
        {
            get { return _CheckedHovImg; }
            set { _CheckedHovImg = value; buttonbase.HoverImage = _CheckedHovImg; }
        }
        public Image CheckedNorImg
        {
            get { return _CheckedNorImg; }
            set { _CheckedNorImg = value; buttonbase.NormalImage = _CheckedNorImg; }
        }

    }
}
