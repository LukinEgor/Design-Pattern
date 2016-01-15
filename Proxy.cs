using System;
  using System.Threading;

  class MainApp
  {
    static void Main()
    {
      // Create math proxy
      IMath p = new MathProxy();

      // Do the math
      Console.WriteLine("4 + 2 = " + p.Add(4, 2));
      Console.WriteLine("4 - 2 = " + p.Sub(4, 2));
      Console.WriteLine("4 * 2 = " + p.Mul(4, 2));
      Console.WriteLine("4 / 2 = " + p.Div(4, 2));

      // Wait for user
      Console.Read();
    }
  }

  /// <summary>
  /// Subject - �������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>���������� ����� ��� <see cref="Math"/> � <see cref="Proxy"/> ���������, ��� ��� �����
  /// <see cref="Proxy"/> ����� ������������ �����, ��� ��������� <see cref="Math"/></lu>
  /// </li>
  /// </remarks>
  public interface IMath
  {
    double Add(double x, double y);
    double Sub(double x, double y);
    double Mul(double x, double y);
    double Div(double x, double y);
  }


  /// <summary>
  /// RealSubject - �������� ������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>���������� �������� ������, �������������� ������������</lu>
  /// </li>
  /// </remarks>
  class Math : IMath
  {
    public Math()
    {
        Console.WriteLine("Create object Math. Wait...");
        Thread.Sleep(1000);
    }

    public double Add(double x, double y){return x + y;}
    public double Sub(double x, double y){return x - y;}
    public double Mul(double x, double y){return x * y;}
    public double Div(double x, double y){return x / y;}
  }

  /// <summary>
  /// Proxy - �����������
  /// </summary>
  /// <remarks>
  /// <li>
  /// <lu>������ ������, ������� ��������� ����������� ���������� � ���������
  /// ��������. ������ ������ <see cref="MathProxy"/> ����� ���������� � ������� ������
  /// <see cref="IMath"/>, ���� ���������� ������� <see cref="Math"/> � <see cref="IMath"/> ���������;</lu>
  /// <lu>������������� ���������, ���������� ���������� <see cref="IMath"/>, ��� ��� �����������
  /// ������ ����� ���� ������������ ������ ��������� ��������;</lu>
  /// <lu>������������ ������ � ��������� �������� � ����� �������� �� ��� �������� 
  /// � ��������;</lu>
  /// <lu>������ ����������� ������� �� ���� �����������:
  /// <li>
  /// <lu><b>��������� �����������</b> �������� �� ����������� ������� � ��� ����������
  /// � ����������� ��������������� ������� ��������� �������� �
  /// ������ �������� ������������;</lu>
  /// <lu><b>����������� �����������</b> ����� ���������� �������������� ����������
  /// � �������� ��������, ����� �������� ��� ��������.</lu>
  /// <lu><b>���������� �����������</b> ���������, ����� �� ���������� ������ 
  /// ����������� ��� ���������� ������� �����;</lu>
  /// </li>
  /// </lu>
  /// </li>
  /// </remarks>
  class MathProxy : IMath
  {
    Math math;

    public MathProxy()
    {
      math = null;
    }

    /// <summary>
    /// ������� �������� - �� ������� ��������� ��������
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public double Add(double x, double y)
    {
      return x + y;
    }

    public double Sub(double x, double y)
    {
      return x - y;
    }

    /// <summary>
    /// ��������� �������� - ������� �������� ��������� ��������
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public double Mul(double x, double y)
    {
      if (math == null)
          math = new Math();
      return math.Mul(x, y);
    }

    public double Div(double x, double y)
    {
      if (math == null)
          math = new Math();
      return math.Div(x, y);
    }
  }