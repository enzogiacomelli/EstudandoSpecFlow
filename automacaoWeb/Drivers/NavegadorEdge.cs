namespace automacaoWeb.Drivers
{
    internal class NavegadorEdge
    {
        public static IWebDriver abrirNavegador()
        {
            IWebDriver driver;
            var edgeOptinos = new EdgeOptions();
            edgeOptinos.PageLoadStrategy = PageLoadStrategy.Normal;
            edgeOptinos.AddArgument("headless");
            driver = new EdgeDriver(edgeOptinos);

            return driver;
        }
    }
}
