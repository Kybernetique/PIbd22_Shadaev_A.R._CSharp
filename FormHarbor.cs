using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsBoat
{
    public partial class FormHarbor : Form
    {
        // Объект от класса-коллекции гавани
        private readonly HarborCollection harborCollection;

        // Логгер
        private readonly Logger logger;

        // Конструктор
        public FormHarbor()
        {
            InitializeComponent();
            harborCollection = new HarborCollection(pictureBoxHarbor.Width, pictureBoxHarbor.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                if (listBoxHarbors.SelectedIndex > -1)
                {
                    harborCollection[listBoxHarbors.SelectedItem.ToString()].Draw(gr);
                }
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
            logger.Info($"Added place {textBoxNewLevelName.Text}");
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
                    logger.Info($"Place was deleted {listBoxHarbors.SelectedItem.ToString()}");
                    harborCollection.DelPlace(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
                Draw();
            }
        }

        // Обработка нажатия кнопки "Take"
        private void buttonTakeBoat_Click_1(object sender, EventArgs e)
        {
            if (listBoxHarbors.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                try
                {
                    var boat = harborCollection[listBoxHarbors.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (boat != null)
                    {
                        FormBoat form = new FormBoat();
                        form.SetBoat(boat);
                        form.ShowDialog();
                        logger.Info($"Boat {boat} Was Taken From Place {maskedTextBoxPlace.Text}");
                        Draw();
                    }
                }
                catch (HarborNotFoundException ex)
                {
                    logger.Warn($"Harbor {maskedTextBoxPlace.Text} Was Not Found");
                    MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Метод обработки выбора элемента на listBoxLevels
        private void listBoxHarbors_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Switched To Harbor {listBoxHarbors.SelectedItem.ToString()}");
            Draw();
        }

        private void AddBoat(Transport boat)
        {
            if (boat != null && listBoxHarbors.SelectedIndex > -1)
            {
                try
                {
                    if ((harborCollection[listBoxHarbors.SelectedItem.ToString()]) + boat)
                    {
                        Draw();
                        logger.Info($"Added Boat {boat}");
                    }
                    else
                    {
                        MessageBox.Show("Could Not Add Boat");
                    }
                    Draw();
                }
                catch (HarborOverflowException ex)
                {
                    logger.Warn($"Couldn't Add Boat {boat}");
                    MessageBox.Show(ex.Message, "Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unknown Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddBoat_Click(object sender, EventArgs e)
        {
            FormBoatConfig formBoatConfig = new FormBoatConfig();
            formBoatConfig.AddEvent(AddBoat);
            formBoatConfig.ShowDialog();
        }

        // Обработка нажатия пункта меню "Save"
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    harborCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Save Succeeded.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Saved to File " + saveFileDialog.FileName);
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn("File Was Not Found");
                    MessageBox.Show(ex.Message, "File Was Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unknown Error When Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработка нажатия пункта меню "Load"
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    harborCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Loaded", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Loaded From File " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (HarborOverflowException ex)
                {
                    logger.Warn($"Couldn't Add Boat");
                    MessageBox.Show(ex.Message, "Harbor's Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn("File Was Not Found");
                    MessageBox.Show(ex.Message, "File Was Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

