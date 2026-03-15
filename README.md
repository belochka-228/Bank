# Практическая 6_часть1_3исип-223_Крохмаль_Коровкина
## Дисциплина
Поддержка и тестирование программных модулей

## Название работы
СОЗДАНИЕ АВТОМАТИЗИРОВАННЫХ UNIT-ТЕСТОВ

## Цель работы
Провести тестирование разработанных программных модулей с использованием средств автоматизации Microsoft Visual Studio методом "белого ящика".

## Разработчики
- Крохмаль София — группа 3исип-223
- Коровкина Алина — группа 3исип-223

## Результаты работы приложения
![Результат работы](https://github.com/belochka-228/Bank/blob/master/Bank/Images/result.png?raw=true)

## Результаты модульного тестирования
![Обозреватель тестов](https://github.com/belochka-228/Bank/blob/master/Bank/Images/%D0%BE%D0%B1%D0%BE%D0%B7%D1%80%D0%B5%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C.png?raw=true)

## Вывод о проведенном тестировании

В ходе тестирования было выполнено **6 модульных тестов** для методов `Debit` и `Credit` класса `BankAccount`.

`Debit_WithValidAmount_UpdatesBalance` - исправлена логическая ошибка в методе Debit (замена += на -=)

`Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange` - корректная проверка условия amount < 0 и использование константы DebitAmountLessThanZeroMessage

`Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange` - корректная проверка условия amount > m_balance и использование константы DebitAmountExceedsBalanceMessage

`Credit_WithValidAmount_UpdatesBalance` - правильная реализация метода Credit

`Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange` - добавлена проверка отрицательных значений и константа CreditAmountLessThanZeroMessage

`Credit_WhenAmountIsZero_UpdatesBalance` - корректная обработка граничного случая (пополнение на 0)

Все тесты успешно пройдены благодаря исправлению логических ошибок в коде и добавлению информативных сообщений об исключениях через константы.
