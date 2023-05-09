namespace AbstractFactory
{
    public class PopularCellPhone:CellPhoneFactory
    {
        public override Processor assemblyProcessor()
        {
            return new NormalProcessor();
        }

        public override Screen assemblyScreen()
        {
            return new HighDefinitionScreen();
        }
    }
}