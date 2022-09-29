namespace comp348_a4_q34
{
    public static class TextFileProcessor
    {
        public class ReadEventArgs : EventArgs
        {
            public ReadEventArgs(string? line)
            {
                Line = line;
            }

            public string? Line { get; private set; }
        }

        private static event EventHandler<ReadEventArgs>? ReadEvent;

        private static void LineRead(object? sender, ReadEventArgs eventArgs)
        {
            // Q3
            Console.WriteLine(eventArgs.Line);

            // Q4
        }

        private static void OnLineRead(string line)
        {
            ReadEvent?.Invoke(null, new ReadEventArgs(line));
        }

        public static void Read(string path)
        {
            try
            {
                string fileText = File.ReadAllText(path);
                string[] fileTextSplit = fileText.Split(Environment.NewLine,
                                StringSplitOptions.RemoveEmptyEntries);

                ReadEvent += LineRead;
                foreach (string line in fileTextSplit)
                {
                    OnLineRead(line);
                }
                ReadEvent -= LineRead;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error, Invalid File");
                Environment.Exit(-1);
            }
        }
    }
}
