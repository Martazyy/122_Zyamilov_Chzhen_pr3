# ПРАКТИЧЕСКАЯ РАБОТА №3
## ОТЛАДКА ПРОГРАММЫ РАЗЛИЧНЫМИ СПОСОБАМИ
### Часть 1/2



### Содержание

- [Задание 1](#задание-1)
- [Задание 2](#задание-2)
- [Задание 3](#задание-3)



## Задание №1
В ходе выполнения задания была проведена отладка программы на C#, вычисляющей элемент последовательности Фибоначчи. Изначально программа возвращала неверное значение для пятого элемента последовательности (3 вместо 5). С использованием отладчика Visual Studio были выполнены следующие шаги:

 - **Создание** проекта: Создан консольный проект.

 - **Анализ кода:** Изучен код, вычисляющий последовательность Фибоначчи, и выявлена ошибка в логике цикла.

 - **Установка точек останова:** Точки останова были установлены на ключевых строках кода для пошагового выполнения и проверки значений переменных.

 - **Пошаговая отладка:** Проверены значения переменных n1, n2, sum и i на каждой итерации цикла.

 - **Обнаружение ошибки:** Выявлено, что цикл завершался на одну итерацию раньше, чем нужно, из-за условия i < n в цикле for.

 - **Исправление ошибки:** Условие цикла изменено на i <= n, что позволило выполнить все необходимые итерации.

 - **Проверка результата:** После исправления программа вернула правильное значение для пятого элемента последовательности Фибоначчи — 5.

***Итог:*** Ошибка успешно исправлена, программа теперь корректно вычисляет элементы последовательности Фибоначчи.



## Задание №2
В ходе выполнения задания было создано консольное приложение на C# для отображения информации о галактиках (название, расстояние, тип). В процессе разработки были выявлены и исправлены ошибки:

 - **Создание проекта:** Создан консольный проект.

 - **Анализ кода:** Изучен код, который выводит информацию о галактиках, и выявлены проблемы:

   - Свойство GalaxyType в классе Galaxy было объявлено как object, что приводило к неправильному выводу типа галактики.

   - Опечатка в операторе switch (case 'l' вместо case 'I') для типа галактики "Irregular".

 - **Отладка:**

   - Установлены точки останова для анализа значений переменных.

   - Исправлено свойство GalaxyType на тип GType, чтобы корректно отображать тип галактики.

   - Исправлена опечатка в операторе switch для правильного определения типа "Irregular".

 - **Проверка результата:** После исправлений приложение выводит корректные данные о галактиках, включая правильные типы.

***Итог:*** Ошибки успешно исправлены, приложение теперь корректно отображает информацию о галактиках.



## Задание №3

В ходе выполнения задания было создано консольное приложение на C#, которое демонстрирует работу с массивом символов и выводом сообщений. Основные шаги и результаты:

 - **Создание проекта:** Создан консольный проект.

 - **Анализ кода:** Изучен код, который формирует строку из массива символов и выводит сообщения с использованием метода SendMessage.

 - **Запуск отладчика:** Приложение запущено с отладчиком (F5), и проверены выходные данные, которые соответствуют ожидаемым:

```
Hello, f! Count to 1
Hello, fr! Count to 2
Hello, fre! Count to 3
Hello, fred! Count to 4
Hello, fred ! Count to 5
Hello, fred s! Count to 6
Hello, fred sm! Count to 7
Hello, fred smi! Count to 8
Hello, fred smit! Count to 9
Hello, fred smith! Count to 10
```
 - **Установка точек останова:** Точка останова установлена в цикле for для анализа значений переменных letters и name.

 - **Пошаговая отладка:**

   - Использованы команды F10 (шаг с обходом) и F11 (шаг с заходом) для пошагового выполнения кода.

   - Проверены значения переменных с помощью подсказок данных и окон "Авто" и "Локальные".

 - **Наблюдение за переменными:** Переменная name добавлена в окно "Наблюдение" для отслеживания её изменений на каждой итерации цикла.

 - **Использование стека вызовов:** Окно "Стек вызовов" использовано для анализа порядка вызова методов (Main и SendMessage).

***Итог:*** Приложение успешно отлажено, все переменные и логика работы проверены. Отладчик помог убедиться в корректности выполнения кода и значений переменных на каждом этапе.
