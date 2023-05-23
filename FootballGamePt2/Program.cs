using FootballGamePt2;

static FootballPlayer[] GeneratePlayers( int count)
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
//Console.WriteLine("Enter the number of players in the firts team:");
//int count = int.Parse(Console.ReadLine());
//FootballPlayer[] teamOnePlayers = new FootballPlayer[count];
//teamOnePlayers = GeneratePlayers(teamOnePlayers);

//for (int i = 0; i < teamOnePlayers.Length; i++)
//{
//    Console.WriteLine("Enter player's position/name/age/number/height:");
//    string[] playersData = Console.ReadLine().Split("/");
//    if (playersData[0] == "striker")
//    {
//        Striker striker = new Striker();
//        striker.Name = playersData[1];
//        striker.Age = int.Parse(playersData[2]);
//        striker.Number = int.Parse(playersData[3]);
//        striker.Height = double.Parse(playersData[4]);
//        teamOnePlayers[i] = striker;
//    }
//    if (playersData[0] == "midfield")
//    {
//        Midfield midfield = new Midfield();
//        midfield.Name = playersData[1];
//        midfield.Age = int.Parse(playersData[2]);
//        midfield.Number = int.Parse(playersData[3]);
//        midfield.Height = double.Parse(playersData[4]);
//        teamOnePlayers[i] = midfield;
//    }
//    if (playersData[0] == "defender")
//    {
//        Defender defender = new Defender();
//        defender.Name = playersData[1];
//        defender.Age = int.Parse(playersData[2]);
//        defender.Number = int.Parse(playersData[3]);
//        defender.Height = double.Parse(playersData[4]);
//        teamOnePlayers[i] = defender;
//    }
//    if (playersData[0] == "goalkeeper")
//    {
//        GoalKeeper goalKeeper = new GoalKeeper();
//        goalKeeper.Name = playersData[1];
//        goalKeeper.Age = int.Parse(playersData[2]);
//        goalKeeper.Number = int.Parse(playersData[3]);
//        goalKeeper.Height = double.Parse(playersData[4]);
//        teamOnePlayers[i] = goalKeeper;
//    }
//}
//FootballPlayer[] teamOnePlayers =
//{
//        new Striker { Name = "Polka", Age = 20, Number = 7, Height = 159},
//        new Striker { Name = "Lora", Age = 18, Number = 8, Height = 164},
//        new Striker { Name = "Maria", Age = 29, Number = 15, Height = 151},
//        new Striker { Name = "Alex", Age = 22, Number = 12, Height = 178},
//        new Striker { Name = "Plamen", Age = 27, Number = 4, Height = 171},
//        new Striker { Name = "Venislav", Age = 31, Number = 6, Height = 194},
//        new Striker { Name = "Kiril", Age = 22, Number = 20, Height = 175},
//        new Striker { Name = "Kalina", Age = 20, Number = 1, Height = 167},
//        new Striker { Name = "Iva", Age = 18, Number = 14, Height = 165},
//        new Striker { Name = "Emil", Age = 28, Number = 10, Height = 192},
//        new Striker { Name = "Peter", Age = 25, Number = 3, Height = 184},
//};
//FootballPlayer[] teamTwoPlayers =
//{
//        new Striker { Name = "Ralica", Age = 29, Number = 8, Height = 159},
//        new Striker { Name = "Elena", Age = 31, Number = 4, Height = 164},
//        new Striker { Name = "Velislava", Age = 24, Number = 11, Height = 151},
//        new Striker { Name = "Kris", Age = 19, Number = 13, Height = 178},
//        new Striker { Name = "Pamela", Age = 18, Number = 1, Height = 171},
//        new Striker { Name = "Lucas", Age = 25, Number = 7, Height = 194},
//        new Striker { Name = "Radoslav", Age = 21, Number = 18, Height = 175},
//        new Striker { Name = "Hristina", Age = 20, Number = 1, Height = 167},
//        new Striker { Name = "Eva", Age = 20, Number = 2, Height = 165},
//        new Striker { Name = "Lubo", Age = 36, Number = 6, Height = 192},
//        new Striker { Name = "Hristo", Age = 40, Number = 14, Height = 184},
//};

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
//Coach[] coach =
//{
//    new Coach{ Name = "Stefan", Age = 50},
//    new Coach{ Name = "Elica", Age = 38},
//    new Coach{ Name = "Miroslav", Age = 42},
//    new Coach{ Name = "Zdavko", Age = 40}
//};

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
//Referee[] referees = 
//{
//    new Referee{Name ="Leo", Age = 38},
//    new Referee{Name ="Yavor", Age = 31},
//    new Referee{Name ="Anelia", Age = 29},
//};
Console.WriteLine("Enter the number of teams:");
int teamCount = int.Parse(Console.ReadLine());
Team[] teams = new Team[teamCount];
for (int i = 0; i < referees.Length-1; i++)
{
    Team team = new Team();
    Console.WriteLine("Enter team's coach number:");
    int coachNum = int.Parse(Console.ReadLine());
    team.Coach = coaches[coachNum];
    //Console.WriteLine("Enter team's players number:");
    //int playersNum = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the number of players in the firts team:");
    int count = int.Parse(Console.ReadLine());
    team.Players = GeneratePlayers(count);
    teams[i] = team;
}

//Team[] teams = 
//{
//    new Team {Coach = coach[1], Players = teamOnePlayers },
//    new Team {Coach = coach[3], Players = teamTwoPlayers },
//};

Game game = new Game();
Console.WriteLine("Enter the first team's number:");
int teamNum1 = int.Parse(Console.ReadLine());
game.TeamOne = teams[teamNum1];
Console.WriteLine("Enter the second team's number:");
int teamNum2 = int.Parse(Console.ReadLine());
game.TeamTwo = teams[teamNum2];
game.Referees = referees;

Console.WriteLine("Enter the number of goals you want:");
int goalsCount = int.Parse(Console.ReadLine());
for (int i = 0; i < goalsCount; i++)
{
    Console.WriteLine("Enter the team number that scored:");
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
//game.AddGoal(game.TeamOne.Players[2], 45);
//game.AddGoal(game.TeamOne.Players[7], 70);
//game.AddGoal(game.TeamTwo.Players[1], 78); 

game.ChangeResult();
game.GameResult();