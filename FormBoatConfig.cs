using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormBoatConfig : Form
    {
        // Переменная-выбранная лодка
        ITransport boat = null;

        // Событие
        private Action<Transport> eventAddBoat;


        public FormBoatConfig()
        {
            InitializeComponent();
            // привязать panelColor_MouseDown к панелям с цветами
            panel1.MouseDown += panelColor_MouseDown;
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        // Отрисовать лодку
        private void DrawBoat()
        {
            if (boat != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.SetPosition(5, 5, pictureBoxBoat.Width, pictureBoxBoat.Height);
                boat.DrawTransport(gr);
                pictureBoxBoat.Image = bmp;
            }
        }

        // Добавление события
        public void AddEvent(Action<Transport> ev)
        {
            if (eventAddBoat == null)
            {
                eventAddBoat = new Action<Transport>(ev);
            }
            else
            {
                eventAddBoat += ev;
            }
        }

        // Передаём информацию при нажатии на Label
        private void labelBoat_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Передаём информацию при нажатии на Label
        private void labelSailboat_MouseDown(object sender, MouseEventArgs e)
        {
            labelSailBoat.DoDragDrop(labelSailBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelBoat_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelBoat_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Simple Boat":
                    boat = new Boat((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Sailboat":
                    boat = new SailBoat((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
checkBoxFront.Checked, checkBoxBack.Checked, checkBoxAnchor.Checked, checkBoxSail.Checked);
                    break;
            }
            DrawBoat();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Принимаем основной цвет // ok
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                boat.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBoat();
            }
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            // Прописать логику проверки приходящего значения на тип Color
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Принимаем дополнительный цвет 
        private void labelSecondaryColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                if (boat is SailBoat)
                {
                    (boat as SailBoat).SetSecondaryColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBoat();
                }
            }
        }

        // Добавление лодки
        private void buttonAppend_Click(object sender, EventArgs e)
        {
            eventAddBoat?.Invoke((Transport)boat);
            Close();
        }
    }
}
