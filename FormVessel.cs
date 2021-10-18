using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormVessel : Form
    {
        private ITransport boat;

        // Конструктор
        public FormVessel()
        {
            InitializeComponent();
        }

        // Передача корабля на форму
        public void SetBoat(ITransport boat)
        {
            this.boat = boat;
            Draw();
        }

        // Метод отрисовки корабля
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBoats.Width, pictureBoxBoats.Height);
            Graphics gr = Graphics.FromImage(bmp);
            boat.DrawTransport(gr);
            pictureBoxBoats.Image = bmp;
        }

        // Кнопка создания лодки
        private void buttonCreateBoat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Khaki);
            //boat.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Khaki, Color.DeepSkyBlue, true, true, true, true);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoats.Width, pictureBoxBoats.Height);
            Draw();
        }

        // Кнопка движения корабля
        private void buttonMove_Click(object sender, EventArgs e)
        {
            // получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    boat.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    boat.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    boat.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    boat.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        // Кнопка создания парусника
        private void buttonCreateSailboat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new SailBoat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Khaki, Color.DeepSkyBlue, true, true, true, true);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoats.Width,
           pictureBoxBoats.Height);
            Draw();
        }
    }
}
