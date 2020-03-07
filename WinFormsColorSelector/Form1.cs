using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsColorSelector
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] colorNames = Enum.GetNames(typeof(KnownColor));
            this.listBoxColors.Items.AddRange(colorNames);
        }

        private void listBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedColor = (KnownColor)Enum.Parse(typeof(KnownColor), listBoxColors.Text);
            SetColor(Color.FromKnownColor(selectedColor));
        }

        #endregion

        #region Methods

        private void SetColor(Color color)
        {
            try
            {
                TrySetColor(color);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void TrySetColor(Color color)
        {
            this.BackColor = color;

            this.labelBrightness.Text = "Brightness:" + this.BackColor.GetBrightness();
            this.labelHue.Text = "Hue:" + this.BackColor.GetHue();
            this.labelSaturation.Text = "Saturation:" + this.BackColor.GetSaturation();
        }

        #endregion
    }
}
