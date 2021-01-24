using System;

namespace IPractice.Music
{
    public interface IPlayableInstrument
    {
        void Play();
    }

    interface Instrument
    {
        string What();
        void Adjust();
    }
    class Wind : Instrument,IPlayableInstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Wind.Play()");
        }
        public virtual string What() { return "Wind"; }
        public virtual void Adjust() { }
    }
    class Percussion : Instrument, IPlayableInstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Percussion.Play()");
        }
        public virtual string What() { return "Percussion"; }
        public virtual void Adjust() { }
    }
    class Stringed : Instrument, IPlayableInstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Stringed.Play()");
        }
        public virtual string What() { return "stringed"; }
        public virtual void Adjust() { }
    }
    class Brass : Wind
    {
        public override void Play()
        {
            Console.WriteLine("Brass.Play()");
        }
        public override void Adjust()
        {
            Console.WriteLine("Brass.Adjust()");
        }
    }

    class Woodwind : Wind
    {
        public override void Play()
        {
            Console.WriteLine("Woodwind.Play()");
        }
        public override string What() { return "Woodwind"; }
    }

}
