namespace IPractice.InterfaceInheritance
{
    public interface A
    {
        void Print();
        void Print(string a);
    }
    public interface B
    {
        void Save();

        void Save(string b);
    }

    public interface C
    {
        void Request();

        void Request(string a);
    }

    public interface D : A, B, C
    {
        void Write();
    }
}
