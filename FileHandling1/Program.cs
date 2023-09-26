class Task1
{
    public static void Main()
    {
        DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\sport\Documents\ACS\Others");

        currDir.Create();

        string path = @"C:\Users\sport\Documents\ACS\Others\info.txt";

        if (!File.Exists(path))
        {
            File.Create(path);
        }

        Console.WriteLine("Write your name: ");
        string name = (Console.ReadLine());
        Console.WriteLine("Write your last name: ");
        string last_name = (Console.ReadLine());
        Console.WriteLine("Write your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Write your hobby: ");
        string hobby = (Console.ReadLine());
        Console.WriteLine("Write your desired university: ");
        string desired_university = (Console.ReadLine());

        string[] info = { name, last_name, age.ToString(), hobby, desired_university };

        //Writing on the file
        File.WriteAllLines(path, info);

        //Read from the file
        foreach (string item in File.ReadAllLines(path))
        {
            Console.WriteLine(item);
        }
    }

}


