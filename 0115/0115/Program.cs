﻿
//p1();
//p2();
//p2_1();
//p2_2();
//p3();
//p3_1();
//Console.WriteLine(p4(2, 10));


// 2 ^ 10 = (2 * 2)^5 = 4 ^ 5
//4 ^ 5 = 4 * 4 ^ 4
// 4 ^ 4 = (4 * 4)^2 = 16 ^2
// 16^2 = (16 * 16) ^1 = 256 ^1
// 256^1 = 256 * 256^0
// 256^0 = 1;
int p4(int a, int n)
{
    if (n == 0)
        return 1;
    else if (n % 2 == 1)
        return a * p4(a, n - 1);
    else
        return p4(a * a, n / 2);
}
static void p1()
{
    int[] v = { 1, 4, 2, 7, 3, 5 };

    int maxim = v[1] - v[0];
    for (int i = 2; i < v.Length; i++)
        if (v[i] - v[i - 1] > maxim)
            maxim = v[i] - v[i - 1];
    Console.WriteLine(maxim);
}

void p2_2()
{
    List<int> list = new List<int>() { 1, 1, 1, 2, 3, 3, 5, 7, 7 };
    List<int> reps = new List<int>();
    int item = list[0], count = 1;
    for(int i = 1; i < list.Count; i++)
        if (list[i] == item)
        {
            count++;
        }
        else
        {
            if (count > 1)
                reps.Add(item);
            item = list[i];
            count = 1;
        }
    if (count > 1)
        reps.Add(item);

    foreach(var it in reps)
        Console.WriteLine(it);
}

void p2_1()
{
    List<int> list = new List<int>() { 1, 1, 1, 2, 3, 3, 5, 7, 7 };
    foreach(var item in list.Distinct())
        Console.WriteLine(item);
}

void p2()
{
    List<int> list = new List<int>() { 1, 1, 1, 2, 3, 3, 5, 7, 7 };
    HashSet<int> set = new HashSet<int>();

    for(int i = 1; i < list.Count; i++)
        if (list[i] == list[i - 1])
            set.Add(list[i]);

    foreach (int item in set)
        Console.WriteLine(item);
}

// pozitia ultimului element par din lista
void p3_1()
{
    int[] v = { 1, 3, 3, 4, 5, 8, 9 };

    int pos = -1;
    for (int i = v.Length - 1; pos == -1 && i >= 0; i--)
        if (v[i] % 2 == 0)
            pos = i;
    if (pos == -1)
        Console.WriteLine("Lista nu contine elemente pare");
    else
        Console.WriteLine($"Ultimul element par este pe pozitia {pos}");
}

// valoarea ultimului element par din lista
void p3()
{
    int[] v = { 1, 3, 5 };
    try
    {
        Console.WriteLine(v.Last(x => x % 2 == 0));
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    
}



//p5();


// determina daca un string este anagrama altuia
void p5()
{
    string s1 = "listen";
    
    string s2 = "silent";
    char[] cs1 = s1.ToCharArray();
    char[] cs2 = s2.ToCharArray();
    Array.Sort(cs1);
    Array.Sort(cs2);
    bool egale = true;
    for(int i = 0; egale && i < cs1.Length; i++)
        if(cs1[i] != cs2[i])
            egale = false;
        
    if(egale)
        Console.WriteLine($"{s1} este anagrama a lui {s2}");
}

p5_1();
void p5_1()
{
    string s1 = "listen";

    string s2 = "silent";
    Dictionary<char, int> d1 = new();
    Dictionary<char, int> d2 = new();

    foreach (var c in s1)
        if (d1.ContainsKey(c))
            d1[c]++;
        else 
            d1[c] = 1;
    foreach (var c in s2)
        if (d2.ContainsKey(c))
            d2[c]++;
        else
            d2[c] = 1;
    bool dictionariesEqual =
    d1.Keys.Count == d2.Keys.Count &&
    d1.Keys.All(k => d2.ContainsKey(k) && (d2[k] == d1[k]));
    Console.WriteLine();
}
