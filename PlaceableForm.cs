using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public enum LocationPolicy
    {
        Corner, Center
    }

    public partial class PlaceableForm : Form
    {
        public PlaceableForm()
        {
            InitializeComponent();

            Load += PlaceableForm_Load;
        }

        private void PlaceableForm_Load(object sender, EventArgs e)
        {
            int startLocationX = _desiredStartLocationX;
            int startLocationY = _desiredStartLocationY;

            if (_desiredStartLocationX != -1 && _desiredStartLocationY != -1)
            {
                switch (_locationPolicy)
                {
                    case LocationPolicy.Center:
                        startLocationX = _desiredStartLocationX - (int)((float)Width / 2f);
                        startLocationY = _desiredStartLocationY - (int)((float)Height / 2f);
                        break;
                }

                startLocationX = Math.Max(0, startLocationX);
                startLocationY = Math.Max(0, startLocationY);

                SetDesktopLocation(startLocationX, startLocationY);
            }
        }

        private int _desiredStartLocationX = -1;
        private int _desiredStartLocationY = -1;
        private LocationPolicy _locationPolicy = LocationPolicy.Center;

        public int DesiredStartLocationX { get => _desiredStartLocationX; set => _desiredStartLocationX = value; }
        public int DesiredStartLocationY { get => _desiredStartLocationY; set => _desiredStartLocationY = value; }

        public LocationPolicy LocationPolicy { get => _locationPolicy; set => _locationPolicy = value; }

        public Point DesiredStartLocation { set { _desiredStartLocationX = value.X; _desiredStartLocationY = value.Y; } }

        public void SetDesiredStartLocation(Point inLocation)
        {
            DesiredStartLocation = inLocation;
        }

        public void SetDesiredStartLocation(int inX, int inY)
        {
            DesiredStartLocationX = inX;
            DesiredStartLocationY = inY;
        }

        public void SetDesiredStartLocation()
        {
            SetDesiredStartLocation(System.Windows.Forms.Cursor.Position);
        }
    }
}
