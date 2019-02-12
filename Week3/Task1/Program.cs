using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    enum FSIMode
    {
        Folder, File
    }
    class Layer
    {
        int selectedIndex;
        public DirectoryInfo[] DirectoryContent
        {
            get;
            set;
        }
        public FileInfo[] FileContent
        {
            get;
            set;
        }
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                if (value < 0) selectedIndex = DirectoryContent.Length + FileContent.Length - 1;
                else if (value > DirectoryContent.Length + FileContent.Length - 1) selectedIndex = 0;
                else selectedIndex = value;
            }
        }
        void SelectedColor(int i)
        {
            if (i == SelectedIndex)
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            else
                Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < DirectoryContent.Length; i++)
            {
                SelectedColor(i);
                Console.WriteLine((i + 1) + ". " + DirectoryContent[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < FileContent.Length; i++)
            {
                SelectedColor(i + DirectoryContent.Length);
                Console.WriteLine((i + DirectoryContent.Length + 1) + ". " + FileContent[i].Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\hp\Desktop\Test");
            Layer l = new Layer
            {
                DirectoryContent = dir.GetDirectories(),
                FileContent = dir.GetFiles(),
                SelectedIndex = 0
            };
            Stack<Layer> history = new Stack<Layer>();
            history.Push(l);
            bool quit = false;
            FSIMode mode = FSIMode.Folder;
            while (!quit)
            {
                if (mode == FSIMode.Folder)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                    history.Peek().SelectedIndex--;

                else if (key.Key == ConsoleKey.DownArrow)
                    history.Peek().SelectedIndex++;

                else if (key.Key == ConsoleKey.Enter)
                {
                    int newopen = history.Peek().SelectedIndex;
                    if (newopen < history.Peek().DirectoryContent.Length)
                    {
                        DirectoryInfo d = history.Peek().DirectoryContent[newopen];
                        history.Push(new Layer
                        {
                            DirectoryContent = d.GetDirectories(),
                            FileContent = d.GetFiles(),
                            SelectedIndex = 0
                        });
                    }
                    else
                    {
                        mode = FSIMode.File;
                        StreamReader sr = new StreamReader(history.Peek().FileContent[newopen - history.Peek().DirectoryContent.Length].FullName);
                        string s = sr.ReadToEnd();
                        sr.Close();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(s);
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (mode == FSIMode.Folder)
                    {
                        if (history.Count > 1)
                            history.Pop();
                    }
                    else
                    {
                        mode = FSIMode.Folder;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                else if (key.Key == ConsoleKey.Escape)
                {
                    quit = true;
                }
            }

        }
    }
}
