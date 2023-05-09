namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static CellPhone assemblyCellPhone(string type)
        {
            CellPhoneFactory cellPhoneFactory = null;

            switch (type)
            {
                case "1":
                    cellPhoneFactory = new PopularCellPhone();
                    break;
                case "2":
                    cellPhoneFactory = new PremiumCellPhone();
                    break;
            }

            CellPhone cellPhone = new CellPhone();
            cellPhone.processor = cellPhoneFactory.assemblyProcessor();
            cellPhone.screen = cellPhoneFactory.assemblyScreen();
            return cellPhone;
        }
    }
}