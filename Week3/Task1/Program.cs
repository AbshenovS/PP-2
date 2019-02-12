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
        DirectoryInfo = 1,
        File
    }
    class Layer
    {
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
            get;
            set;
        }
        void SelectedColor(int i)
        {
            if (i == SelectedIndex)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
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
            FSIMode mode = FSIMode.DirectoryInfo;
            while (!quit)
            {
                if (mode == FSIMode.DirectoryInfo)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (history.Peek().SelectedIndex > 0)
                    {
                        history.Peek().SelectedIndex--;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (history.Peek().SelectedIndex < history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 1)
                    {
                        history.Peek().SelectedIndex++;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length == 0) { break; }
                    int newdir = history.Peek().SelectedIndex;
                    if (newdir < history.Peek().DirectoryContent.Length)
                    {
                        DirectoryInfo d = history.Peek().DirectoryContent[newdir];
                        history.Push(new Layer
                        {
                            DirectoryContent = d.GetDirectories(),
                            FileContent = d.GetFiles(),
                            SelectedIndex = 0
                        });
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (mode == FSIMode.DirectoryInfo)
                    {
                        if (history.Count > 1)
                            history.Pop();
                    }
                    else
                    {
                        mode = FSIMode.DirectoryInfo;
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
