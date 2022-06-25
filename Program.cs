// internal class Program
// {
//     private static void Main(string[] args)
//     {   
//         Console.Write($"Ismingizni kiriting -> ");
//         string ism = Console.ReadLine();

//         string text = System.IO.File.ReadAllText(@"/home/abdulaziz/Abdulaziz/dotNetLessons/Multiple-choice-quiz-app/Testlar.txt");

//             Console.WriteLine();
//             string [] savollar = text
//                 .Split('^', StringSplitOptions.RemoveEmptyEntries)
//                 .ToArray() ;

//             for (var i = 0; i < savollar.Length; i++)
//             {
//                 Random rd = new Random();
//                 int rand_num = rd.Next(0,savollar.Length);

//                 string[] testSavoliArray = savollar[rand_num]
//                     .Split('@', StringSplitOptions.RemoveEmptyEntries)
//                     .ToArray();

//                 string testSavoli = testSavoliArray[0];
//                 string[] testVariantlari = testSavoliArray[1]
//                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//                     .ToArray();    
//                 var quest = new Questions(testSavoli,testVariantlari,i+1);
//                 int ball = 0;
//                 var test = new Test(ism,quest.ToString(),60,testVariantlari[4],ball);  
//                 test.TakeTest();
//             }   

//         // Start
//     }
// }

List<string> savollar = new List<string>();

using (StreamReader read = new StreamReader("Testlar.txt"))
{
    while (!read.EndOfStream)
    {
        savollar.Add(read.ReadLine());
    }
}

List<string[]> javoblar = new List<string[]>();
for (var i = 0; i < savollar.Count; i++)
{
    javoblar.Add(savollar[i].Split('(',StringSplitOptions.RemoveEmptyEntries));
}
var test = new Test("Mantiqiy!",javoblar,50);

test.TakeTest();