using System.Collections.Generic;
using System;
using System.Drawing;

class Menu
{
    Point coords = new Point();
    List<string> items = new List<string>();
    int cursor;

    public Menu(int x, int y, List<string> items)
    {
        coords.X = x;
        coords.Y = y;
        this.items = items;
        cursor = 0;
    }

    public void show()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.SetCursorPosition(coords.X, i + coords.Y);
            if (i == cursor)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.Write(items[i]);
            Console.ResetColor();
        }
    }

    public void clearMenu()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.SetCursorPosition(coords.X, i + coords.Y);
            for (int j = 0; j < items[i].Length; j++)
            {
                Console.Write(" ");
            }
        }
    }

    public int navigate()
    {
        ConsoleKeyInfo key;


        while (true)
        {
            show();
            key = Console.ReadKey();


            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (cursor > 0)
                    {
                        cursor--;
                        clearMenu();
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (cursor < items.Count - 1)
                    {
                        cursor++;
                        clearMenu();
                    }
                    break;

                case ConsoleKey.Enter:
                    clearMenu();
                    return cursor;

                default:
                    break;
            }
        }
    }
}
