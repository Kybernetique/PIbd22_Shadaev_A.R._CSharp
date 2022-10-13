using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormHarbor : Form
    {
        // Объект от класса-коллекции гавани
        private readonly HarborCollection harborCollection;

        // Конструктор
        public FormHarbor()
        {
            InitializeComponent();
            harborCollection = new HarborCollection(pictureBoxHarbor.Width, pictureBoxHarbor.Height);
            Draw();
        }

        // Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = listBoxHarbors.SelectedIndex;

            listBoxHarbors.Items.Clear();
            for (int i = 0; i < harborCollection.Keys.Count; i++)
            {
                listBoxHarbors.Items.Add(harborCollection.Keys[i]);
            }

            if (listBoxHarbors.Items.Count > 0 && (index == -1 || index >= listBoxHarbors.Items.Count))
            {
                listBoxHarbors.SelectedIndex = 0;
            }
            else if (listBoxHarbors.Items.Count > 0 && index > -1 && index < listBoxHarbors.Items.Count)
            {
                listBoxHarbors.SelectedIndex = index;
            }
        }

        // Метод отрисовки гавани
        private void Draw()
        {
            if (listBoxHarbors.SelectedIndex > -1)
            {
                // Если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxHarbor.Width, pictureBoxHarbor.Height);
                Graphics gr = Graphics.FromImage(bmp);
                harborCollection[listBoxHarbors.SelectedItem.ToString()].Draw(gr);
                pictureBoxHarbor.Image = bmp;
            }
        }

        // Обработка нажатия кнопки "Add Harbor"
        private void buttonAddHarbor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Enter A Harbor's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            harborCollection.AddPlace(textBoxNewLevelName.Text);

            ReloadLevels();
        }

        // Обработка нажатия кнопки "Del Harbor"
        private void buttonDelHarbor_Click(object sender, EventArgs e)
        {
            if (listBoxHarbors.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Del Harbor {listBoxHarbors.SelectedItem.ToString()}?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    harborCollection.DelPlace(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
                Draw();
            }
        }

        // Обработка нажатия кнопки "Set Boat"
        private void buttonSetBoat_Click_1(object sender, EventArgs e)
        
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, dialog.Color);
                if (harborCollection[listBoxHarbors.SelectedItem.ToString()] + boat > -1)
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
                    if (harborCollection[listBoxHarbors.SelectedItem.ToString()] + boat > -1)
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

                var boat = harborCollection[listBoxHarbors.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (boat != null)
                {
                    FormVessel form = new FormVessel();
                    form.SetBoat(boat);

                    form.ShowDialog();
                }
                Draw();
            }
        }

        // Метод обработки выбора элемента на listBoxLevels
        private void listBoxHarbors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

    }
}
