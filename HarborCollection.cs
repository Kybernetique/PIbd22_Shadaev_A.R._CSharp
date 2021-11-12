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
        readonly Dictionary<string, Harbor<Transport>> harborStages;

        // Возвращение списка названий мест гаваней
        public List<string> Keys => harborStages.Keys.ToList();

        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисовки
        private readonly int pictureHeight;

        // Разделитель для записи информации в 
        private readonly char separator = ':';

        // Конструктор
        public HarborCollection(int pictureWidth, int pictureHeight)
        {
            harborStages = new Dictionary<string, Harbor<Transport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        // Добавление места гавани
        public void AddPlace(string name)
        {
            if (!harborStages.ContainsKey(name))
            {
                harborStages.Add(name, new Harbor<Transport>(pictureWidth, pictureHeight));
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
        public Harbor<Transport> this[string ind]
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

        // Сохранение информации по автомобилям на парковках в файл
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write($"HarborCollection{Environment.NewLine}", sw);
                foreach (var level in harborStages)
                {
                    // Начинаем гавань
                    sw.Write($"Harbor{separator}{level.Key}{Environment.NewLine}", sw);
                    ITransport boat = null;
                    for (int i = 0; (boat = level.Value.GetNext(i)) != null; i++)
                    {
                        if (boat != null)
                        {
                            // Если место не пустое
                            // Записываем тип лодки
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
            return true;
        }

        // Загрузка нформации по лодкам в гавани из файла
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            harborStages.Clear();

            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string line;
                Transport boat = null;
                string key = string.Empty;
                line = sr.ReadLine();
                if (!line.Contains("HarborCollection"))
                {
                    return false;
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Harbor"))
                    {
                        key = line.Split(separator)[1];
                        harborStages.Add(key, new Harbor<Transport>(pictureWidth, pictureHeight));
                    }
                    else if (line.Split(separator)[0] == "Boat")
                    {
                        boat = new Boat(line.Split(separator)[1]);
                        var result = harborStages[key] + boat;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else if (line.Split(separator)[0] == "SailBoat")
                    {
                        boat = new SailBoat(line.Split(separator)[1]);
                        var result = harborStages[key] + boat;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return true;
        }
    }
}

