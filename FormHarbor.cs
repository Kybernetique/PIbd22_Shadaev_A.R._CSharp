using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormHarbor : Form
    {
        // Объект от класса-гавани
        private readonly Harbor<Boat> harbor;

        // Конструктор
        public FormHarbor()
        {
            InitializeComponent();
            harbor = new Harbor<Boat>(pictureBoxHarbor.Width, pictureBoxHarbor.Height);
            Draw();
        }

        // Метод отрисовки
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHarbor.Width, pictureBoxHarbor.Height);
            Graphics gr = Graphics.FromImage(bmp);
            harbor.Draw(gr);
            pictureBoxHarbor.Image = bmp;
        }

        // Обработка нажатия кнопки "Set Boat"
        private void buttonSetBoat_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, dialog.Color);
                if ((harbor + boat) > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Harbor Is Full!");
                }
            }
        }

        // Обработка нажатия кнопки "Set Sailboat"
        private void buttonSetSailboat_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var boat = new SailBoat(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                    if ((harbor + boat) > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Harbor Is Full!");
                    }
                }
            }
        }

        // Обработка нажатия кнопки "Take"
        private void buttonTakeVessel_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var boat = harbor - Convert.ToInt32(maskedTextBox.Text);
                if (boat != null)
                {
                    FormVessel form = new FormVessel();
                    form.SetBoat(boat);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
