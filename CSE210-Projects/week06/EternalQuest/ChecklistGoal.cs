using System.Threading.Channels;

public class ChecklistGoal:Goal
{
    private int _timesCompleted=0;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int timesCompleted, int targetCount, int bonus)
    :base(name, description, points)

    {
        _timesCompleted=timesCompleted;
        _targetCount=targetCount;
        _bonus= bonus;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    

    public override int RecordEvent()
    {
        _timesCompleted++;
        if(_timesCompleted==_targetCount)
        {
            return _points +_bonus;
        }
        return _points;
    }

    public override bool IsComplete()=> _timesCompleted>=_targetCount;
    public override string GetStatus()=>
    (IsComplete() ? "[X]" : "[ ]") + $" {_name} -- Completed {_timesCompleted}/{_targetCount} times";
    public override string strialize()=>
    $"ChecklistGoal|{_name}|{_description}|{_points}|{_timesCompleted}|{_targetCount}|{_bonus}";

   

    
   
    
}