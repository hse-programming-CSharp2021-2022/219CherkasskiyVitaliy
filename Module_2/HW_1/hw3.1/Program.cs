using System;

namespace hw3._1
{
    class VideoFile
    {
        private string _name;
        private int _duration;
        private int _quality;
        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }
        public int Size => _duration * _quality;
        public string GetInfo()
        {
            return $"{_name}\n-----\nDuration: {_duration}\nQuality: {_quality}";
        }
    }
    class Program
    {
        public static string getRandomLine()
        {
            string answer = "";
            var rand = new Random();
            int lengthOfLine = rand.Next(2, 9);
            for (int i = 0; i < lengthOfLine; ++i)
            {
                answer += (char)rand.Next(65, 91);
            }
            return answer;
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            while (true)
            {
                VideoFile[] filesArray = new VideoFile[rand.Next(5, 16)];
                for (int i = 0; i < filesArray.Length; ++i)
                {
                    filesArray[i] = new VideoFile(getRandomLine(), rand.Next(60, 361), rand.Next(100, 1001));
                }
                Console.Write($"Choose a file(from 0 to {filesArray.Length - 1}): ");
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < filesArray.Length)
                {
                    foreach (var file in filesArray)
                    {
                        if (file.Size > filesArray[index].Size)
                        {
                            Console.WriteLine();
                            Console.WriteLine(file.GetInfo());
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
    }
}
