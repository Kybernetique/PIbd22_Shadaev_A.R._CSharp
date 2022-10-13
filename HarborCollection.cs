using System.Collections.Generic;
using System.Linq;


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

        // Конструктор
        public HarborCollection(int pictureWidth, int pictureHeight)
        {
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            harborStages = new Dictionary<string, Harbor<Transport>>();

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

    }
}
