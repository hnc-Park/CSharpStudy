
/* ================= 예제 4.13 참조 형식의 Equals 메서드의 동작 방식 ================= */

class Book
{
    decimal _isbn;

    public Book(decimal isbn)
    {
        _isbn = isbn;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book(9788998139018);
        Book book2 = new Book(9788998139018);

        Console.WriteLine(book1.Equals(book2)); // 출력 결과: False

        book1 = book2;
        Console.WriteLine(book1.Equals(book2));// 출력 결과: True

        string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
        string txt2 = new string(new char[] { 't', 'e', 'x', 't' });

        Console.WriteLine(txt1.Equals(txt2)); // 출력 결과: True

        txt1 = txt2;
        Console.WriteLine(txt1.Equals(txt2)); // 출력 결과: True
    }
}

