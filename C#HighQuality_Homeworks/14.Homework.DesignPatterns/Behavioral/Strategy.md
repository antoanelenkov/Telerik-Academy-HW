# Strategy Pattern

## Мотивация

 * Служи за  постигане на дадена цел по различни начини. Входните данни и крайният резултат са еднакви. Чрез избора ни на стратегия решаваме по какъв начин точно да се достигне до този резултат. 

## Цел

 * Капсулиране на логиката за извършване на определено действие, вдигане на абстракцията и лесна подмяна на въпросната логика при необходимост

## Приложение

* Пример 1:

	Имаме колекция от данни, които искаме да сортираме по даден критерий. Известно е, че при наличие на голям брой елементи, ефективни сортиращи алгоритми са "Quicksort" и "Mergesort", докато при колекции с по-малък брой елементи ефективен алгоритъм е "Selectionsort". Бихме могли да напишем логика, която спрямо броят на елементи в колекцията да избира правилната стратегия за сортиране.
    
    
* Пример 2:

	Създаваме си engine на игра като искаме въпросната игра да използва за UI както конзолата, така и някакъв друг графичен интерфейс. Съответно имаме съобщения, които трябва да изписваме на потребителя. Функционалността за изписването им можем да обвием в интерфейс, който да се наследява от два класа, които  от своя страна имплементират тази функционалност както за конзолата, така и за другия графичен интерфейс.
    
    Следващата стъпка е в конструктора на engine-a на играта да подадем съответната стратегия(клас) за различнит графични интерфейси. 
    
    Предимството е, че използвайки този подход много лесно можем да добавим нова стратегия за трети, четвърти вид интерфейс без да променяме вече готов код.

	
	
    
## Известни употреби
* C# sorting strategy, hashing algorithms strategies, encrypting algorithms strategies

## Имплментация 

```c#
using System;
using System.Collections.Generic;
 
namespace DoFactory.GangOfFour.Strategy.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Strategy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Two contexts following different strategies
      SortedList studentRecords = new SortedList();
 
      studentRecords.Add("Samual");
      studentRecords.Add("Jimmy");
      studentRecords.Add("Sandra");
      studentRecords.Add("Vivek");
      studentRecords.Add("Anna");
 
      studentRecords.SetSortStrategy(new QuickSort());
      studentRecords.Sort();
 
      studentRecords.SetSortStrategy(new ShellSort());
      studentRecords.Sort();
 
      studentRecords.SetSortStrategy(new MergeSort());
      studentRecords.Sort();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Strategy' abstract class
  /// </summary>
  abstract class SortStrategy
  {
    public abstract void Sort(List<string> list);
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class QuickSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      list.Sort(); // Default is Quicksort
      Console.WriteLine("QuickSorted list ");
    }
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class ShellSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      //list.ShellSort(); not-implemented
      Console.WriteLine("ShellSorted list ");
    }
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class MergeSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      //list.MergeSort(); not-implemented
      Console.WriteLine("MergeSorted list ");
    }
  }
 
  /// <summary>
  /// The 'Context' class
  /// </summary>
  class SortedList
  {
    private List<string> _list = new List<string>();
    private SortStrategy _sortstrategy;
 
    public void SetSortStrategy(SortStrategy sortstrategy)
    {
      this._sortstrategy = sortstrategy;
    }
 
    public void Add(string name)
    {
      _list.Add(name);
    }
 
    public void Sort()
    {
      _sortstrategy.Sort(_list);
 
      // Iterate over list and display results
      foreach (string name in _list)
      {
        Console.WriteLine(" " + name);
      }
      Console.WriteLine();
    }
  }
}
  ```

## Последствия
* Лесно добаване на нови стратегии 

## Сродни модели
* Понякога се бърка с Bridge pattern

## Проблеми
* Комуникацията между ползвателя на стратегията и класа, който я представлява се случва през базов абстрактен клас, който трябва да осигури интерфейс за всички видове стратегии и понякога би могло да се случи така, че някоя стратегия да няма нужда от някой компонент на интерфейса.

## UML  диаграма

![alt text](http://www.dofactory.com/images/diagrams/net/strategy.gif)
