using System;

namespace lab_3 {
  public class pulemet {
    const int V = 1, maxTst = 90, Tokrsr = 23, nag1st = 2, Vosts = 1;
    int Stoptime;
    int tekTst = Tokrsr;
    public bool Shot(int amount) {
      if (Stoptime > DateTime.Now.Second) {
        Console.WriteLine("Данное действие в данный момент невозможно. Время перезарядки {0} секунд", Stoptime - DateTime.Now.Second);
        return true;
      }
      int i = 0;
      if ((tekTst + (nag1st * amount)) > maxTst) {
        i = amount - ((maxTst - tekTst) / nag1st);
        amount = amount - i;
      }
      tekTst += nag1st * amount; //++ temperature
      Stoptime = DateTime.Now.Second + (V * amount); //get tick
      Console.WriteLine("Произведено {0} выстрелов", amount);
      Console.WriteLine("Время паузы: {0} секунд", Stoptime - DateTime.Now.Second); 
      Console.WriteLine("Текущая температура ствола {0}C", tekTst);
      if (i > 0) {
        Console.WriteLine("Не произведено {0} выстрелов из-за перегрева ствола", i);
      }
      return true;
    }
    public void CheckTemp() => Console.WriteLine("Текущая температура ствола {0}C", tekTst);
    public void ChangeSt() {
      tekTst = Tokrsr;
      Console.WriteLine("Ствол сменён. Текущая температура ствола {0}C", tekTst);
    }
    public void Pause( int time ) { 
      Stoptime = DateTime.Now.Second + (V * time);
    }
  }
}
