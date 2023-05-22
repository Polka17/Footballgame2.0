using FootballGamePt2;

FootballPlayer[] teamOnePlayers =
{
        new Striker { Name = "Polka", Age = 20, Number = 7, Height = 159},
        new Striker { Name = "Lora", Age = 18, Number = 8, Height = 164},
        new Striker { Name = "Maria", Age = 29, Number = 15, Height = 151},
        new Striker { Name = "Alex", Age = 22, Number = 12, Height = 178},
        new Striker { Name = "Plamen", Age = 27, Number = 4, Height = 171},
        new Striker { Name = "Venislav", Age = 31, Number = 6, Height = 194},
        new Striker { Name = "Kiril", Age = 22, Number = 20, Height = 175},
        new Striker { Name = "Kalina", Age = 20, Number = 1, Height = 167},
        new Striker { Name = "Iva", Age = 18, Number = 14, Height = 165},
        new Striker { Name = "Emil", Age = 28, Number = 10, Height = 192},
        new Striker { Name = "Peter", Age = 25, Number = 3, Height = 184},
};
FootballPlayer[] teamTwoPlayers =
{
        new Striker { Name = "Ralica", Age = 29, Number = 8, Height = 159},
        new Striker { Name = "Elena", Age = 31, Number = 4, Height = 164},
        new Striker { Name = "Velislava", Age = 24, Number = 11, Height = 151},
        new Striker { Name = "Kris", Age = 19, Number = 13, Height = 178},
        new Striker { Name = "Pamela", Age = 18, Number = 1, Height = 171},
        new Striker { Name = "Lucas", Age = 25, Number = 7, Height = 194},
        new Striker { Name = "Radoslav", Age = 21, Number = 18, Height = 175},
        new Striker { Name = "Hristina", Age = 20, Number = 1, Height = 167},
        new Striker { Name = "Eva", Age = 20, Number = 2, Height = 165},
        new Striker { Name = "Lubo", Age = 36, Number = 6, Height = 192},
        new Striker { Name = "Hristo", Age = 40, Number = 14, Height = 184},
};

Coach[] coach =
{
    new Coach{ Name = "Stefan", Age = 50},
    new Coach{ Name = "Elica", Age = 38},
    new Coach{ Name = "Miroslav", Age = 42},
    new Coach{ Name = "Zdavko", Age = 40}
};

Referee[] referees = 
{
    new Referee{Name ="Leo", Age = 38},
    new Referee{Name ="Yavor", Age = 31},
    new Referee{Name ="Anelia", Age = 29},
};

Team[] teams = 
{
    new Team {Coach = coach[1], Players = teamOnePlayers },
    new Team {Coach = coach[3], Players = teamTwoPlayers },
};

Game game = new Game();
game.TeamOne = teams[0];
game.TeamTwo = teams[1];
game.Referees = referees;

game.AddGoal(game.TeamOne.Players[2], 45);
game.AddGoal(game.TeamOne.Players[7], 70);
game.AddGoal(game.TeamTwo.Players[1], 78); 

game.ChangeResult();
game.GameResult();