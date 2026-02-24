using System;

Player player = new Player();
player.ShowStatus();

Character hero = new Character();

hero.SetInfo("용사", 10);
hero.ShowInfo();

Say say = new Say();
say.Hi();

Schedule schedule = new Schedule();
schedule.PrintWeekDays();

DefaultValues dv = new DefaultValues();
dv.ShowDefaults();

Counter c1 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);
Counter c2 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);
Counter c3 = new Counter();
Console.WriteLine("현재 카운트: " + Counter.count);

Player2 p1 = new Player2("용사");
Player2 p2 = new Player2("마법사");
Player2 p3 = new Player2("궁수");

Console.WriteLine(p1.name);
Console.WriteLine(p2.name);
Console.WriteLine(p3.name);
Console.WriteLine("총 플레이어 수: " + Player2.totalCount);

GameConfig config = new GameConfig(4);
config.ShowConfig();

Example ex = new Example();
ex.ShowValues();

Player3 player3 = new Player3();
player3.SetInfo("용사", 10);
player3.ShowInfo();

Person person = new Person();
person.ShowProfile();

GameCharacter herO = new GameCharacter("용사", 15);
GameCharacter mage = new GameCharacter("마법사", 25);

herO.ShowStatus();
Console.WriteLine();
mage.ShowStatus();
Console.WriteLine();

herO.TakeDamage(30);
herO.TakeDamage(50);
herO.TakeDamage(50);

Console.WriteLine();
GameCharacter.ShowTotalCharacters();

class Player
{
    private string name = "이름없음";
    private int health = 100;
    private int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("체력: " + health);
        Console.WriteLine("레벨: " + level);
    }
}

class Character
{
    private string name;
    private int level;

    public void SetInfo(string n, int lv)
    {
        name = n;
        level = lv;
    }

    public void ShowInfo()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("레벨: " + level);
    }
}

class Say
{
    private string message = "안녕하세요.";

    public void Hi()
    {
        message = "반갑습니다.";
        Console.WriteLine(message);
    }
}

class Schedule
{
    private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    public void PrintWeekDays()
    {
        foreach (var day in weekDays) { Console.WriteLine(day + "\t"); }
        Console.WriteLine();
    }
}

class DefaultValues
{
    private int number;
    private bool flag;
    private string text;

    public void ShowDefaults()
    {
        Console.WriteLine("number: " + number);
        Console.WriteLine("flag: " + flag);
        Console.WriteLine("text: " + (text == null ? "null" : text));
    }
}

class Counter
{
    public static int count = 0;
    public Counter()
    {
        count++;
    }
}

class Player2
{
    public string name;
    public static int totalCount;

    public Player2(string n)
    {
        name = n;
        totalCount++;
    }
}

class GameConfig
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayers;

    public GameConfig(int max)
    {
        maxPlayers = max;
    }

    public void ShowConfig()
    {
        Console.WriteLine("버전: " + version);
        Console.WriteLine("최대 플레이어: " + maxPlayers);
    }
}

class Example
{
    public const double Pi = 3.14159;

    public readonly DateTime createdAt = DateTime.Now;

    public void ShowValues()
    {
        Console.WriteLine("원주율: " + Pi);
        Console.WriteLine("생성 시간: " + createdAt);
    }
}

class Player3
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine("이름: " + this.name);
        Console.WriteLine("레벨: " + this.level);
    }
}

class Person
{
    private string name = "홍길동";
    private const int Age = 21;
    private readonly string nickName = "길동이";
    private string[] websites = { "네이버", "구글" };

    public void ShowProfile()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("나이: " + Age);
        Console.WriteLine("닉네임: " + nickName);
        Console.WriteLine("사이트: " + string.Join(", ", websites));
    }
}

class GameCharacter
{
    private string name;
    private int health;
    private int attack;

    private static int characterCount = 0;
    private readonly int maxHealth = 100;
    private const int MinHealth = 0;

    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.health = maxHealth;
        this.attack = attack;
        characterCount++;
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
        if (health < MinHealth)
        {
            health = MinHealth;
        }
        Console.WriteLine(name + "이(가) " + damage + " 데미지를 받음! 남은 체력: " + health);
    }

    public void ShowStatus()
    {
        Console.WriteLine("=== " + name + " ===");
        Console.WriteLine("체력: " + health + "/" + maxHealth);
        Console.WriteLine("공격력: " + attack);
    }

    public static void ShowTotalCharacters()
    {
        Console.WriteLine("총 캐릭터 수: " + characterCount);
    }
}