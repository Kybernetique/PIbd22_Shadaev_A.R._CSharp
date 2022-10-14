using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsBoat
{
    // Класс-коллекция мест гавани
    class HarborCollection
    {
        // Словарь (хранилище) с местами гавани
        readonly Dictionary<string, Harbor<Vehicle>> harborStages;

        // Возвращение списка названий мест гаваней
        public List<string> Keys => harborStages.Keys.ToList();

        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисовки
        private readonly int pictureHeight;

        // Разделитель для записи информации в 
        private readonly char separator = ':';

        private readonly Logger logger;

        // Конструктор
        public HarborCollection(int pictureWidth, int pictureHeight)
        {
            harborStages = new Dictionary<string, Harbor<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            logger = LogManager.GetCurrentClassLogger();
        }

        // Добавление места гавани
        public void AddPlace(string name)
        {
            if (!harborStages.ContainsKey(name))
            {
                harborStages.Add(name, new Harbor<Vehicle>(pictureWidth, pictureHeight));
            }
        }

        // Удаление места гавани
        public void DelPlace(string name)
        {
            if (harborStages.ContainsKey(name))
            {
                harborStages.Remove(name);
            }
        }

        // Доступ к парковке
        public Harbor<Vehicle> this[string ind]
        {
            get
            {
                if (harborStages.ContainsKey(ind))
                {
                    return harborStages[ind];
                }
                return null;
            }
        }

        // Сохранение информации по лодкам на парковках в файл
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write($"HarborsCollection{Environment.NewLine}", sw);

                foreach (var level in harborStages)
                {
                    //Начинаем парковку
                    sw.Write($"Harbor{separator}{level.Key}{Environment.NewLine}", sw);
                    foreach (ITransport boat in level.Value)
                    {
                        //Записываем тип мшаины
                        if (boat.GetType().Name == "Boat")
                        {
                            sw.Write($"Boat{separator}", sw);
                        }
                        if (boat.GetType().Name == "SailBoat")
                        {
                            sw.Write($"SailBoat{separator}", sw);
                        }
                        //Записываемые параметры
                        sw.Write(boat + Environment.NewLine, sw);
                    }
                }
            }
        }


        // Загрузка информации по лодкам в гавани из файла
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);

            string line = sr.ReadLine();

            if (line.Contains("HarborsCollection"))
            {
                harborStages.Clear();
            }
            else
            {
                throw new ArgumentException();
            }

            Vehicle boat = null;
            string key = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("Harbor"))
                {
                    key = line.Split(separator)[1];
                    harborStages.Add(key, new Harbor<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                if (line.Split(separator)[0] == "Boat")
                {
                    boat = new Boat(line.Split(separator)[1]);
                }
                else if (line.Split(separator)[0] == "SailBoat")
                {
                    boat = new SailBoat(line.Split(separator)[1]);
                }
                if ((harborStages[key] + boat) == false)
                {
                    throw new TypeLoadException("Couldn't add boat to harbor");
                }
            }
        }
    }
}


