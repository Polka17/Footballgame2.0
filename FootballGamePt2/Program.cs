using FootballGamePt2;
/*
    SOME INFO YOU CAN USE TO COPY AS PLAYER INPUT FOR IT TO BE FASTER!!!

    striker/Miro/21/4/184
    defender/Iliyan/18/7/178
    defender/Ivan/23/12/191
    midfield/Petko/34/15/169
    striker/Dimitur/25/10/173
    midfield/Preslav/21/1/182
    goalkeeper/Kris/27/25/181
    midfield/Alex/22/3/177
    defender/Mihail/18/5/180
    striker/Pavel/19/17/165
    striker/Milen/31/6/170

    defender/Moni/21/4/180
    defender/Ela/20/7/172
    defender/Bora/22/12/188
    midfield/Iva/19/15/169
    striker/Dimi/25/10/178
    midfield/Polka/20/1/162
    striker/Kristin/20/25/164
    midfield/Alex/22/3/179
    defender/Mika/18/5/172
    goalkeeper/Aria/19/17/165
    striker/Rali/21/6/159
 */
static FootballPlayer[] GeneratePlayers(int count)
{
    FootballPlayer[] playersC = new FootballPlayer[count];

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Enter player's position/name/age/number/height:");
        string[] playersData = Console.ReadLine().Split("/");
        if (playersData[0] == "striker")
        {
            Striker striker = new Striker();
            striker.Name = playersData[1];
            striker.Age = int.Parse(playersData[2]);
            striker.Number = int.Parse(playersData[3]);
            striker.Height = double.Parse(playersData[4]);
            playersC[i] = striker;
        }
        if (playersData[0] == "midfield")
        {
            Midfield midfield = new Midfield();
            midfield.Name = playersData[1];
            midfield.Age = int.Parse(playersData[2]);
            midfield.Number = int.Parse(playersData[3]);
            midfield.Height = double.Parse(playersData[4]);
            playersC[i] = midfield;
        }
        if (playersData[0] == "defender")
        {
            Defender defender = new Defender();
            defender.Name = playersData[1];
            defender.Age = int.Parse(playersData[2]);
            defender.Number = int.Parse(playersData[3]);
            defender.Height = double.Parse(playersData[4]);
            playersC[i] = defender;
        }
        if (playersData[0] == "goalkeeper")
        {
            GoalKeeper goalKeeper = new GoalKeeper();
            goalKeeper.Name = playersData[1];
            goalKeeper.Age = int.Parse(playersData[2]);
            goalKeeper.Number = int.Parse(playersData[3]);
            goalKeeper.Height = double.Parse(playersData[4]);
            playersC[i] = goalKeeper;
        }
    }
    return playersC;
}


Console.WriteLine("----Coaches----");
Console.WriteLine("Enter the number of coaches:");
int coachCount = int.Parse(Console.ReadLine());
Coach[] coaches = new Coach[coachCount];
for (int i = 0; i < coaches.Length; i++)
{
    Coach coach = new Coach();
    Console.WriteLine("Enter coach's name:");
    coach.Name = Console.ReadLine();
    Console.WriteLine("Enter coach's age:");
    coach.Age = int.Parse(Console.ReadLine());
    coaches[i] = coach;
}


Console.WriteLine("----Referees----");
Referee[] referees = new Referee[3];
for (int i = 0; i < referees.Length; i++)
{
    Referee referee = new Referee();
    Console.WriteLine("Enter referee's name:");
    referee.Name = Console.ReadLine();
    Console.WriteLine("Enter referee's age:");
    referee.Age = int.Parse(Console.ReadLine());
    referees[i] = referee;
}


Console.WriteLine("----Teams----");
Console.WriteLine("Enter the number of teams:");
int teamCount = int.Parse(Console.ReadLine());
Team[] teams = new Team[teamCount];
for (int i = 0; i < referees.Length - 1; i++)
{
    Team team = new Team();
    Console.WriteLine("Enter team's coach number(array number):");
    int coachNum = int.Parse(Console.ReadLine());
    team.Coach = coaches[coachNum];
    Console.WriteLine($"Enter the number of players in the {i + 1} team:");
    int count = int.Parse(Console.ReadLine());
    team.Players = GeneratePlayers(count);
    teams[i] = team;
    Console.WriteLine();
}

Console.WriteLine("----Game----");
Game game = new Game();
Console.WriteLine("Enter the first team's number(array number):");
int teamNum1 = int.Parse(Console.ReadLine());
game.TeamOne = teams[teamNum1];
Console.WriteLine("Enter the second team's number(array number):");
int teamNum2 = int.Parse(Console.ReadLine());
game.TeamTwo = teams[teamNum2];
game.Referees = referees;


Console.WriteLine("----Goals----");
Console.WriteLine("Enter the number of goals you want:");
int goalsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < goalsCount; i++)
{
    Console.WriteLine("Enter the team number(array number) that scored:");
    int teamNum = int.Parse(Console.ReadLine());
    if (teamNum == 1)
    {
        Console.WriteLine("Enter the player's number(array number):");
        int playerNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the minute:");
        int minute = int.Parse(Console.ReadLine());
        game.AddGoal(game.TeamOne.Players[playerNum], minute);
    }
    if (teamNum == 2)
    {
        Console.WriteLine("Enter the player's number(array number):");
        int playerNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the minute:");
        int minute = int.Parse(Console.ReadLine());
        game.AddGoal(game.TeamTwo.Players[playerNum], minute);
    }
}
Console.WriteLine();
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Game Info");

game.ChangeResult();
game.GameResult();