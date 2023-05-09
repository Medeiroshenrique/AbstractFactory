namespace AbstractFactory
{
    public abstract class CellPhoneFactory
    {
        public abstract Processor assemblyProcessor();
        public abstract Screen assemblyScreen();
    }
}