# Chain Of Responsibilities

Chain of Responsibilities е поведенчески шаблон за дизайн, който позволява една заявка да се предава от един обект на следващ, докато не бъде обработена. По този начин се намалява cupling-a между подателя на заявката и обекта, който я обработва. Пример за подобен шаблон е работата на банкомата.

### 1. Заявката
Първо създаваме отделен клас за вида на заявката - в случая сума за изтегляне от банкомата. Nothing fancy...


```
 internal class Purchase    {        public Purchase(double amount)        {            this.Amount = amount;        }        public double Amount { get; set; }    }
```

### 2. База
Базов абстрактен клас за одобряване на заявката - може да обработи заявката или да я препрати към "наследник". 

```
/// <summary>    /// The 'handler' abstract class    /// </summary>    internal abstract class Approver    {        protected Approver Successor { get; set; }        public void setSuccessor(Approver successor)        {            this.Successor = successor;        }        public abstract void ProcessRequest(Purchase purchase);    }
```

###3. Наследниците
В случая с банкомата имаме нужда да проверим сумата и наличността на банкноти в банкомата(но ние си представяме, че има налични неограничен брой банкноти от всички видове). Ако сумата е по-голяма или равна на 100 долара - банкомата плюе парите, ако не - предава заявката на следващия Approver - 50 доларовата банкнота.

```
namespace ChainOfResponsibilityATM{    using System;    /// <summary>    /// the 'Concrete Handler'    /// </summary>    internal class HundredDollarApprover : Approver    {        public override void ProcessRequest(Purchase purchase)        {            if (purchase.Amount >= 100.0)            {                var givenSum = 0;                Console.WriteLine(                    "{0} approved request for #{1} dollars",                    this.GetType().Name, purchase.Amount);                while (purchase.Amount >= 100)                {                    Console.WriteLine(                   "┌───────────────────────────┐\n" +                   "│ $                       $ │\n" +                   "│                           │\n" +                   "│            100            │\n" +                   "│                           │\n" +                   "│ $                       $ │\n" +                   "└───────────────────────────┘");                    purchase.Amount -= 100;                    givenSum += 100;                }                Console.WriteLine("After giving {0} there are still {1} to give.", givenSum, purchase.Amount);                Console.WriteLine("Processing request to {0}", this.Successor.GetType().Name);                this.Successor.ProcessRequest(purchase);            }            else if (this.Successor != null)            {                this.Successor.ProcessRequest(purchase);            }        }    }}
```
Имплементацията на всички по-нисши approvers е аналогична. Изпращащият заявката знае само за следващия поред обект, който може да я обработи. Той съответно знае само за следващия и т.н.

###4. Дъно

Малко напомня рекурсия - съответно трябва да си има дъно. Банкоматите не дават повече от 5 долара, затова когато стигнем до там трябва да завършим веригата.

```
 else            {                Console.WriteLine("{0} can't handle this request. ATM can't give less than 5 dollars");            }
```

### 5. Клиентът
Клиентът създава и връзва веригата:

```
static void Main()        {            Approver hundred = new HundredDollarApprover();            Approver fifty = new FiftyDollarApprover();            Approver twenty = new TwentyDollarApprover();            Approver ten = new TenDollarApprover();            Approver five = new FiveDollarApprover();            hundred.setSuccessor(fifty);            fifty.setSuccessor(twenty);            twenty.setSuccessor(ten);            ten.setSuccessor(five);            Console.WriteLine("Please, enter the amount of money you like to withdraw:");            var amount = double.Parse(Console.ReadLine());            var purchase = new Purchase(amount);            hundred.ProcessRequest(purchase);            Console.ReadLine();        }
```


 ![Class Diagram](http://prikachi.com/images/347/8373347M.png)

