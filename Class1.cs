/*using System;
using System.IO;

public static class LessonHeaders
{
    public static string Lesson1 { get; set; } = "Math";
    public static string Lesson2 { get; set; } = "Science";
    public static string Lesson3 { get; set; } = "History";
    public static string Lesson4 { get; set; } = "Art";
    public static string Lesson5 { get; set; } = "Physical Education";

    public static void SaveToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(Lesson1);
                writer.WriteLine(Lesson2);
                writer.WriteLine(Lesson3);
                writer.WriteLine(Lesson4);
                writer.WriteLine(Lesson5);
            }
            //Console.WriteLine("Lesson headers saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving lesson headers to file: " + ex.Message);
        }
    }


    public static void LoadFromFile(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Lesson1 = reader.ReadLine();
                Lesson2 = reader.ReadLine();
                Lesson3 = reader.ReadLine();
                Lesson4 = reader.ReadLine();
                Lesson5 = reader.ReadLine();
            }
            //Console.WriteLine("Lesson headers loaded from file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading lesson headers from file: " + ex.Message);
        }
    }
}
*/