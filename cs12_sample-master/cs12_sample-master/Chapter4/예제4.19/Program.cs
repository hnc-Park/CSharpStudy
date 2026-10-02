
/* ================= 예제 4.19 Book 타입의 Equals 개선 ================= */

//class Book
//{
//    decimal isbn13;
//    string title;
//    string contents;

//    public Book(decimal isbn13, string title, string contents)
//    {
//        this.isbn13 = isbn13;
//        this.title = title;
//        this.contents = contents;
//    }

//    public override bool Equals(object obj)
//    {
//        Book book = obj as Book;

//        if (book == null)
//        {
//            return false;
//        }

//        return this.isbn13 == book.isbn13;
//    }

//    public override int GetHashCode()
//    {
//        return this.isbn13.GetHashCode();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Book book1 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
//        Book book2 = new Book(9788998139018, "리버스 엔지니어링 바이블", "......");
//        Book book3 = new Book(9788992939409, "파이썬 3.2 프로그래밍", "......");

//        Console.WriteLine("book1 == book2: " + book1.Equals(book2));
//        Console.WriteLine("book1 == book3: " + book1.Equals(book3));
//    }
//}



///* ================= 4.4.2.2 연산자 오버로드 - Gram 변환 - ================= */

public class Kilogram
{
    double mass;

    public Kilogram(double value)
    {
        this.mass = value;
    }

    public Kilogram Add(Kilogram target)
    {
        return new Kilogram(this.mass + target.mass);
    }

    public override string ToString()
    {
        return mass + "kg";
    }

    public static Kilogram operator +(Kilogram op1, Kilogram op2)
    {
        return new Kilogram(op1.mass + op2.mass);
    }

    static public implicit operator Gram(Kilogram kilogram)
    {
        return new Gram(kilogram.mass * 1000);
    }

}

public class Gram
{
    double mass;

    public Gram(double value)
    {
        this.mass = value;
    }

    public Gram Add(Gram target)
    {
        return new Gram(this.mass + target.mass);
    }

    public override string ToString()
    {
        return mass + "g";
    }

    public static Gram operator +(Gram op1, Gram op2)
    {
        return new Gram(op1.mass + op2.mass);
    }

    static public implicit operator Kilogram(Gram gram)
    {
        return new Kilogram(gram.mass / 1000);
    }

}


    class Program
{
    static void Main(string[] args)
    {


        Kilogram kg1 = new Kilogram(5);
        Kilogram kg2 = new Kilogram(10);

        Kilogram kg3 = kg1.Add(kg2);
        Console.WriteLine(kg3); // 출력 결과: 15kg

        kg3 = kg1 + kg2;
        Console.WriteLine(kg3); // 출력 결과: 15kg

        Gram g1 = new Gram(5);
        Gram g2 = (Gram)kg1;
        Kilogram kg4 = (Kilogram)g1;

        Console.WriteLine(kg4);
        Console.WriteLine(g2);

    }
}
