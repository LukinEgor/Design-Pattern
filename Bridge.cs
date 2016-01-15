using System;

namespace Bridge
{

  // MainApp test application

  class MainApp
  {
    static void Main()
    {
      Abstraction ab = new RefinedAbstraction();

      // Set implementation and call
      ab.Implementor = new ConcreteImplementorA();
      ab.Operation();

      // Change implementation and call
      ab.Implementor = new ConcreteImplementorB();
      ab.Operation();

      // Wait for user
      Console.Read();
    }
  }

  /// <summary>
  /// Abstraction - ����������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>���������� ��������� ����������;</lu>
  /// <lu>������ ������ �� ������ <see cref="Implementor"/></lu>
  /// </li>
  /// </remarks>
  class Abstraction
  {
    // Property
    public Implementor Implementor { get; set; }

    public virtual void Operation()
    {
      Implementor.Operation();
    }
  }

  /// <summary>
  /// Implementor - ����������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>���������� ��������� ��� ������� ����������. �� �� ������ �����
  /// ��������������� ���������� ������ <see cref="Abstraction"/>. �� ����� ���� ���
  /// ���������� ����� ���� ���������� ��������. ������ ��������� ������
  /// <see cref="Implementor"/> ������������ ������ ����������� ��������, � �����
  /// <see cref="Abstraction"/> ���������� �������� ����� �������� ������, 
  /// ������������ �� ���� ����������;</lu>
  /// </li>
  /// </remarks>
  abstract class Implementor
  {
    public abstract void Operation();
  }

  /// <summary>
  /// RefinedAbstraction - ���������� ����������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>��������� ���������, ������������ ����������� <see cref="Abstraction"/></lu>
  /// </li>
  /// </remarks>
  class RefinedAbstraction : Abstraction
  {
    public override void Operation()
    {
      Implementor.Operation();
    }
  }

  /// <summary>
  /// ConcreteImplementor - ���������� ����������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>�������� ���������� ���������� ���������� <see cref="Implementor"/></lu>
  /// </li>
  /// </remarks>
  class ConcreteImplementorA : Implementor
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteImplementorA Operation");
    }
  }

  // "ConcreteImplementorB"

  class ConcreteImplementorB : Implementor
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteImplementorB Operation");
    }
  }
}