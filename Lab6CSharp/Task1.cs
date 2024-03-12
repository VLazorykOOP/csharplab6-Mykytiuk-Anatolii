using System;

interface IUserInterface
{
    void Show();
}

interface INetInterface
{
    void Connect();
}

class Test : IUserInterface
{
    protected string testName;
    protected int numberOfQuestions;

    public Test(string name, int numQuestions)
    {
        testName = name;
        numberOfQuestions = numQuestions;
        Console.WriteLine("Конструктор класу Test з двома параметрами викликано.");
    }

    public Test(string name) : this(name, 0)
    {
        Console.WriteLine("Конструктор класу Test з одним параметром викликано.");
    }

    public Test() : this("Загальний тест", 0)
    {
        Console.WriteLine("Конструктор класу Test без параметрів викликано.");
    }

    ~Test()
    {
        Console.WriteLine("Деструктор класу Test викликано.");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Тест: {testName}");
        Console.WriteLine($"Кількість питань: {numberOfQuestions}");
    }
}

class Exam : Test, INetInterface
{
    protected string subject;

    public Exam(string name, int numQuestions, string subj) : base(name, numQuestions)
    {
        subject = subj;
        Console.WriteLine("Конструктор класу Exam з трьома параметрами викликано.");
    }

    public Exam(string name, string subj) : base(name)
    {
        subject = subj;
        Console.WriteLine("Конструктор класу Exam з двома параметрами викликано.");
    }

    public Exam(string name) : base(name)
    {
        subject = "Предмет не вказано";
        Console.WriteLine("Конструктор класу Exam з одним параметром викликано.");
    }

    ~Exam()
    {
        Console.WriteLine("Деструктор класу Exam викликано.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Предмет: {subject}");
    }

    public void Connect()
    {
        Console.WriteLine("Підключення до мережі...");
    }
}

class FinalExam : Exam
{
    protected int grade;

    public FinalExam(string name, int numQuestions, string subj, int grd) : base(name, numQuestions, subj)
    {
        grade = grd;
        Console.WriteLine("Конструктор класу FinalExam з чотирма параметрами викликано.");
    }

    public FinalExam(string name, string subj, int grd) : base(name, subj)
    {
        grade = grd;
        Console.WriteLine("Конструктор класу FinalExam з трьома параметрами викликано.");
    }

    public FinalExam(string name, int grd) : base(name)
    {
        grade = grd;
        Console.WriteLine("Конструктор класу FinalExam з двома параметрами викликано.");
    }

    ~FinalExam()
    {
        Console.WriteLine("Деструктор класу FinalExam викликано.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Оцінка: {grade}");
    }
}

class Quiz : Test
{
    protected string topic;

    public Quiz(string name, int numQuestions, string tp) : base(name, numQuestions)
    {
        topic = tp;
        Console.WriteLine("Конструктор класу Quiz з трьома параметрами викликано.");
    }

    public Quiz(string name, string tp) : base(name)
    {
        topic = tp;
        Console.WriteLine("Конструктор класу Quiz з двома параметрами викликано.");
    }

    public Quiz(string name) : base(name)
    {
        topic = "Тема не вказана";
        Console.WriteLine("Конструктор класу Quiz з одним параметром викликано.");
    }

    ~Quiz()
    {
        Console.WriteLine("Деструктор класу Quiz викликано.");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Тема: {topic}");
    }
}
