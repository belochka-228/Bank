using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    /// <summary>
    /// Банковский счет клиента
    /// </summary>
    public class BankAccount 
    {
        /// <summary>
        /// Имя владельца
        /// </summary>
        private readonly string m_customerName;

        /// <summary>
        /// Текущий баланс
        /// </summary>
        private double m_balance;

        /// <summary>
        /// Предотвращает создание экземпляров класса <see cref="BankAccount"/> без параметров
        /// </summary>
        private BankAccount() { }

        /// <summary>
        /// Новый экземпляр класса <see cref="BankAccount"/> с указанным именем и начальным балансом
        /// </summary>
        /// <param name="customerName">Имя владельца</param>
        /// <param name="balance">Начальный баланс</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Получает имя владельца 
        /// </summary>
        /// <value>Имя владельца</value>
        public string CustomerName
        {
            get { return m_customerName; }
        }

        /// <summary>
        /// Получает текущий баланс
        /// </summary>
        /// <value>Текущий баланс</value>
        public double Balance
        {
            get { return m_balance; }
        }

        /// <summary>
        /// Выполняет операцию списания со счета
        /// </summary>
        /// <param name="amount">Сумма для списания со счета</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Выбрасывается, когда сумма списания превышает текущий баланс или является отрицательной
        /// </exception>
        /// <remarks>
        /// Метод проверяет, что сумма списания не превышает текущий баланс и не является отрицательной
        /// В случае успешной проверки сумма списывается со счета
        /// </remarks>
        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount; // должно быть вычитание
        }

        /// <summary>
        /// Выполняет операцию зачисления на счет
        /// </summary>
        /// <param name="amount">Сумма для зачисления на счет</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Выбрасывается, когда сумма зачисления является отрицательной
        /// </exception>
        /// <remarks>
        /// Метод проверяет, что сумма зачисления не является отрицательной
        /// и в случае успешной проверки сумма зачисляется на счет
        /// </remarks>
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        /// <summary>
        /// Главная точка входа
        /// </summary>
        /// <remarks>
        /// Создает тестовый банковский счет, выполняет несколько операций
        /// и выводит итоговый баланс на консоль
        /// </remarks>
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}