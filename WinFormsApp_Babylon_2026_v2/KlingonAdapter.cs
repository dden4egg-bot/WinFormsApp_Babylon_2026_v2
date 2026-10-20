using System.Drawing;
using SharedInterfaces; // Наш интерфейс
using KlingonData;      // Сторонняя библиотека (из DLL)

namespace WinFormsApp_Babylon_2026_v2
{
    public class KlingonAdapter : IAncientScript
    {
        // Создаём экземпляр класса из вражеской DLL
        private readonly KlingonData.KlingonData _klingon = new KlingonData.KlingonData();

        // В библиотеке клингонов нет понятия "Родина", выдаём свою строку
        public string GetOrigin()
        {
            return "Klingon Empire (Qo'noS)";
        }

        // Перенаправляем Translate -> DecodeWarriorCry
        public string Translate(string rawData)
        {
            return _klingon.DecodeWarriorCry(rawData);
        }

        // Перенаправляем GetEmblem -> GetWarriorInsignia
        public Image GetEmblem()
        {
            return _klingon.GetWarriorInsignia();
        }
    }
}