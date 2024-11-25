using System.Collections.Generic;
class CricketTeam
{
    public List<int> s=new List<int>();

    public void PointsCalculation(int no_of_matches)
    {

        Console.WriteLine($"Enter the score for {no_of_matches} Matches");

        for( int i = 0; i < no_of_matches; i++ )
        {
            Console.WriteLine($"Match {i+1} Score : ");
            int score=Convert.ToInt32( Console.ReadLine() );
            s.Add( score );

        }

        int Sum_of_scores=s.Sum();

        int avg_score=(int)s.Average();

        Console.WriteLine($"Total no of matches = {no_of_matches}");

        Console.WriteLine($"Total Score = {Sum_of_scores}");

        Console.WriteLine($"Average Score = {avg_score}");

        


    }



}

class ipl
{
    public static void Main(string[] args)
    {

        int n_o_m;

        CricketTeam c=new CricketTeam();

        

        Console.WriteLine("Enter the number of matches");
        n_o_m=Convert.ToInt32( Console.ReadLine() );

        
       c.PointsCalculation(n_o_m);

        
      





    }







}
