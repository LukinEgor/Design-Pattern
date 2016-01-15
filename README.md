﻿# Design-Pattern
Summary design pattern(C#)

Паттерн Хранитель(Memento) используется, когда:
  - необходимо сохранить снимок состояния объекта (или его части) для последующего восстановления
  - прямой интерфейс получения состояния объекта раскрывает детали реализации и нарушает инкапсуляцию объекта
  
Паттерн Цепочка обязанностей(Chain of responsibility) ипользуется, когда:
  - в разрабатываемой системе имеется группа объектов, которые могут обрабатывать сообщения определенного типа;
  - все сообщения должны быть обработаны хотя бы одним объектом системы;
  - сообщения в системе обрабатываются по схеме «обработай сам либо перешли другому», то есть одни сообщения 
  обрабатываются на том уровне, где они получены, а другие пересылаются объектам иного уровня.

Паттерн Наблюдатель(Observer) ипользуется, когда:
  - существует, как минимум, один объект, рассылающий сообщения;
  - имеется не менее одного получателя сообщений, причём их количество и состав могут изменяться во время работы приложения;
  - нет надобности очень сильно связывать взаимодействующие объекты, что полезно для повторного использования.

Паттерн Команда(Command):
  - обеспечивает обработку команды в виде объекта, что позволяет сохранять её, передавать в качестве 
параметра методам, а также возвращать её в виде результата, как и любой другой объект.

Паттерн Состояние(State):
  - используется в тех случаях, когда во время выполнения программы объект должен менять свое поведение
в зависимости от своего состояния.

Паттерн Интерпретатор(Interpreter):
  - решает часто встречающуюся, но подверженную изменениям, задачу. 

Паттерн Стратегия(Strategy) ипользуется, когда:
  - программа должна обеспечивать различные варианты алгоритма или поведения
  - нужно изменять поведение каждого экземпляра класса
  - необходимо изменять поведение объектов на стадии выполнения
  - введение интерфейса позволяет классам-клиентам ничего не знать о классах, реализующих этот интерфейс и инкапсулирующих
в себе конкретные алгоритмы

Паттерн Итератор(Iterator):
  - позволяет получить последовательный доступ к элементам объекта-агрегата без использования описаний каждого 
из агрегированных объектов.

Паттерн Шаблонный метод(Template method) используется тогда, когда:
  - требуется однократное использование инвариантной части алгоритма, с оставлением изменяющейся части на усмотрение
наследникам
  - необходимы локализация и вычленение общего для нескольких классов кода для избегания дублирования
  - требуется разрешение расширения кода наследниками только в определенных местах

Паттерн Постредник(Mediator):
  - обеспечивает взаимодействие множества объектов, формируя при этом слабую связанность и избавляя объекты от необходимости
явно ссылаться друг на друга.

Паттерн Адаптер(Adapter):
  - предназначен для организации использования функций объекта, недоступного для модификации, через специально 
созданный интерфейс.

Паттерн Заместитель(Proxy):
  - предоставляет объект, который контролирует доступ к другому объекту, перехватывая все вызовы 
(выполняет функцию контейнера).

Паттерн Мост(Bridge):
  - используется в проектировании программного обеспечения, чтобы «разделять абстракцию и реализацию так, 
чтобы они могли изменяться независимо». 

Паттерн Компоновщик(Composite pattern):
  - объединяет объекты в древовидную структуру для представления иерархии от частного к целому. Компоновщик 
позволяет клиентам обращаться к отдельным объектам и к группам объектов одинаково.



