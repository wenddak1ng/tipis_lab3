using System;

namespace lab_3 {
  class MainClass {
    static string selected;
    static void Main(string[] args) {
      Console.Title = "Лабораторная работа 3";
      pulemet pul = new pulemet();
      while (true) {
        Console.WriteLine("Доступные действия: Выстрел / Ствол / Температура / Стоп / Остановить");
        Console.Write("Для продолжения выберите действие: ");
        selected = Console.ReadLine().ToLower();
        if (selected == "выстрел") {
          Console.Write("Введите количество выстрелов: ");
          selected = Console.ReadLine();
          pul.Shot(int.Parse(selected));
        }
        else if (selected == "стоп") break;
        else if (selected == "температура") pul.CheckTemp();
        else if (selected == "ствол") pul.ChangeSt();
        else if (selected == "остановить") {
          Console.Write("Введите время паузы (в секундах): ");
          selected = Console.ReadLine();
          pul.Pause(int.Parse(selected));
        }
      }
    }
  }
}
