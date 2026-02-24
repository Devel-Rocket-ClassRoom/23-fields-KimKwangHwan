using System;

ScoreTracker math = new ScoreTracker("수학");
math.ShowScore();
Console.WriteLine();

math.SetScore(85);
math.AddBonus(10);
math.AddBonus(20);
math.SetScore(-10);
Console.WriteLine();

math.ShowScore();


class ScoreTracker
{
    private const int MaxScore = 100;
    private const int MinScore = 0;
    private readonly string name;
    private int current_score = 0;
    private int bonus_count = 0;

    public ScoreTracker(string name)
    {
        this.name = name; 
    }

    public void SetScore(int score)
    {
        if (score < MinScore || score > MaxScore)
        {
            Console.WriteLine($"점수는 {MinScore}~{MaxScore} 사이여야 합니다.");
            return;
        }
        current_score = score;
        Console.WriteLine($"점수는 {score}점으로 설정했습니다.");
    }

    public void AddBonus(int bonus)
    {
        current_score += bonus;
        bonus_count++;
        if (current_score > MaxScore)
        {
            current_score = MaxScore;
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {current_score}점 (최대 점수 도달)");
            return;
        }
        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {current_score}점");
    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"점수: {current_score} / {MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonus_count}");
    }
}