using System;

namespace DesignPatterns.Behavioral.Strategy
{
    // ����� ����������� ���������� ���������, ������ ����������� ���� ���������
    // ����� ��������� ���������� ���� ��������� ��� ������ ���������� ���������
    public interface IStrategy
    {
        void Algorithm();
    }

    // ������ ���������� ����������-���������.
    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("����������� �������� ��������� 1.");
        }
    }

    // ������ ���������� ����������-���������.
    // ���������� ����� ���� ������� ������ �����.
    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("����������� �������� ��������� 2.");
        }
    }

    // ��������, ������������ ��������� ��� ������� ����� ������.
    public class Context
    {
        // ������ �� ��������� IStrategy
        // ��������� ������������� ������������� ����� ����������� ������������
        // (������� �������, ��� ����� ���������� ���������).
        private IStrategy _strategy;

        // ����������� ���������.
        // �������������� ������ ����������.
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // ����� ��� ��������� ���������.
        // ������ ��� ����� ��������� �� ����� ����������.
        // � C# ����� ���� ���������� ����� ��� �������� ������.
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // ��������� ���������������� ���������, ������� ��������
        //��������� � ���������� � ��� ������� ����� ������.
        public void ExecuteOperation()
        {
            _strategy.Algorithm();
        }
    }

    // ����� ����������.
    // � ������ ������� ��������� ��� ������ ���������.
    public static class Program
    {
        // <summary>
        // ����� ����� � ���������.
        // </summary>
        public static void Main()
        {
            // ������ �������� � �������������� ��� ������ ����������.
            Context context = new Context(new ConcreteStrategy1());
            // ��������� �������� ���������, ������� ���������� ������ ���������.
            context.ExecuteOperation();
            // �������� � ��������� ������ ��������� ������.
            context.SetStrategy(new ConcreteStrategy2());
            // ��������� �������� ���������, ������� ������ ���������� ������ ���������.
            context.ExecuteOperation();
        }
    }
}
