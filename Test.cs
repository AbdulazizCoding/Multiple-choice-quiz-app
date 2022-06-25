public class Test
{    
    public string Name{get;set;}
    public List<String[]> Questions{get;set;}
    public int PassingPercentage{get;set;}
    public Test(string name, List<string[]> questions, int passingPercentage)
    {
        Name = name;
        Questions = questions;
        PassingPercentage = passingPercentage;
    }
    public string PrintQuestions(int n)
    {
        Console.WriteLine($"{n}) {Questions[n][0]}");
        var javoblar = Questions[n][2..];

        for (var i = 0; i < javoblar.Length; i++)
        {
            Console.WriteLine($"{((EOption) (i+65)).ToString()} = {javoblar[i]}");
        }
        Console.WriteLine($" ----- Javob kiriting -----");
        
        return Console.ReadLine();
    }
    public void TakeTest()
    {
        List<string> Javoblari = new List<string>();
        int togrilari = 0;
        for (var i = 0; i < Questions.Count; i++)
        {
            Javoblari.Add(PrintQuestions(i));
        }
        for (var i = 0; i < Javoblari.Count; i++)
        {
            var togriJavob = Questions[i][1];
            if(togriJavob == Javoblari[i])
            {
                togrilari++;
            }
        }
        Console.Clear();
        if(togrilari>0)
        {
            Console.WriteLine($"Siz {togrilari} ta to'g'ri topdingiz uraa..");
            if((Questions.Count/PassingPercentage) < togrilari)
            {
                Console.WriteLine(@$"---------- Barakalla --------- ");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Bittaham topmadingiz! ");
        }
    }
}