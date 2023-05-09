namespace AbstractFactory
{
    public class PremiumCellPhone:CellPhoneFactory
    {
        public override Processor assemblyProcessor()
        {
            return new HighPerformanceProcessor();
        }
        

        public override Screen assemblyScreen()
        {
            return new FullHDScreen();
        }
    }
}