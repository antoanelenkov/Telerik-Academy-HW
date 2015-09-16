# Mediator Pattern

## Мотивация

 * Играе ролята на посредник за обмен на информация между множество обекти. Вместо всеки един от тях да се грижи да предава информацията, един посредник го прави. Резултатът е, че обектите знаят само за посредника, а не за всички останали обекти.
 

## Цел

* Избягване на спагети код, който се получава при many-to-many връзки между обектите

## Приложение

* Пример:
 
	Нека имаме въздушно пространство, в което всеки един самолет трябва да информира всички останали къде се намира. Комуникацията би била една голяма каша. В такъв момент се появява нуждата от посредник(mediator), който в слуая е всяка навигационна кула на летищата. Този посредник има собствена логика, в която се решава как да се получава взаимодействието между различните самолети. В този случай самолетът има отговорността единствено да изпрати информацията без да изпълнява допълнителни действия. По този начин се спазват едни от най-важните принципи за писане на качествен код - strong cohesion, loose coupling на класовете.
	
  

## Имплментация 

```c#
using System;
using System.Collections.Generic;
 
namespace DoFactory.GangOfFour.Mediator.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Mediator Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create chatroom
      Chatroom chatroom = new Chatroom();
 
      // Create participants and register them
      Participant George = new Beatle("George");
      Participant Paul = new Beatle("Paul");
      Participant Ringo = new Beatle("Ringo");
      Participant John = new Beatle("John");
      Participant Yoko = new NonBeatle("Yoko");
 
      chatroom.Register(George);
      chatroom.Register(Paul);
      chatroom.Register(Ringo);
      chatroom.Register(John);
      chatroom.Register(Yoko);
 
      // Chatting participants
      Yoko.Send("John", "Hi John!");
      Paul.Send("Ringo", "All you need is love");
      Ringo.Send("George", "My sweet Lord");
      Paul.Send("John", "Can't buy me love");
      John.Send("Yoko", "My sweet love");
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Mediator' abstract class
  /// </summary>
  abstract class AbstractChatroom
  {
    public abstract void Register(Participant participant);
    public abstract void Send(
      string from, string to, string message);
  }
 
  /// <summary>
  /// The 'ConcreteMediator' class
  /// </summary>
  class Chatroom : AbstractChatroom
  {
    private Dictionary<string,Participant> _participants = 
      new Dictionary<string,Participant>();
 
    public override void Register(Participant participant)
    {
      if (!_participants.ContainsValue(participant))
      {
        _participants[participant.Name] = participant;
      }
 
      participant.Chatroom = this;
    }
 
    public override void Send(
      string from, string to, string message)
    {
      Participant participant = _participants[to];
 
      if (participant != null)
      {
        participant.Receive(from, message);
      }
    }
  }
 
  /// <summary>
  /// The 'AbstractColleague' class
  /// </summary>
  class Participant
  {
    private Chatroom _chatroom;
    private string _name;
 
    // Constructor
    public Participant(string name)
    {
      this._name = name;
    }
 
    // Gets participant name
    public string Name
    {
      get { return _name; }
    }
 
    // Gets chatroom
    public Chatroom Chatroom
    {
      set { _chatroom = value; }
      get { return _chatroom; }
    }
 
    // Sends message to given participant
    public void Send(string to, string message)
    {
      _chatroom.Send(_name, to, message);
    }
 
    // Receives message from given participant
    public virtual void Receive(
      string from, string message)
    {
      Console.WriteLine("{0} to {1}: '{2}'",
        from, Name, message);
    }
  }
 
  /// <summary>
  /// A 'ConcreteColleague' class
  /// </summary>
  class Beatle : Participant
  {
    // Constructor
    public Beatle(string name)
      : base(name)
    {
    }
 
    public override void Receive(string from, string message)
    {
      Console.Write("To a Beatle: ");
      base.Receive(from, message);
    }
  }
 
  /// <summary>
  /// A 'ConcreteColleague' class
  /// </summary>
  class NonBeatle : Participant
  {
    // Constructor
    public NonBeatle(string name)
      : base(name)
    {
    }
 
    public override void Receive(string from, string message)
    {
      Console.Write("To a non-Beatle: ");
      base.Receive(from, message);
    }
  }
}
  ```

## Последствия
* Лесно комуникация между еднотипни обекти

## Сродни модели
* Observer Pattern


## UML  диаграма

![alt text](http://www.dofactory.com/images/diagrams/net/mediator.gif)
