using System;

namespace Decorator
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA dA = new ConcreteDecoratorA();
            ConcreteDecoratorB dB = new ConcreteDecoratorB();

            // Link decorators
            dA.SetComponent(c);
            dB.SetComponent(dA);

            dA.Operation();

            Console.WriteLine();

            dB.Operation();

            // Wait for user
            Console.Read();
        }
    }

    /// <summary>
    /// Component - ���������
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>���������� ��������� ��� ��������, �� ������� ����� ���� ����������� 
    /// ��������� �������������� �����������;</lu>
    /// </li>
    /// </remarks>
    abstract class Component
    {
        public abstract void Operation();
    }

    /// <summary>
    /// ConcreteComponent - ���������� ���������
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>���������� ������, �� ������� ����������� �������������� �����������</lu>
    /// </li>
    /// </remarks>
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.Write("������");
        }
    }

    /// <summary>
    /// Decorator - ���������
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>������ ������ �� ������ <see cref="Component"/> � ���������� ���������,
    /// ��������������� ���������� <see cref="Component"/></lu>
    /// </li>
    /// </remarks>
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    /// <summary>
    /// ConcreteDecoratorA - ���������� ���������
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>��������� �������� ������</lu>
    /// </li>
    /// </remarks>
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
        }
    }

    /// <summary>
    /// ConcreteDecorator - ���������� ���������
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>��������� �������� ������ + ��������������</lu>
    /// </li>
    /// </remarks>
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();

            Console.Write(" ���!");
        }
    }
}