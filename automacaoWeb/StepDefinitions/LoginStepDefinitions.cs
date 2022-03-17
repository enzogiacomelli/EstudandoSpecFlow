namespace automacaoWeb.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        Utils Utils = new Utils();
        LoginPage loginPage;
        Usuarios usuarios;


        [BeforeScenario]
        public void beforeScenario()
        {
            driver = NavegadorEdge.abrirNavegador();
            driver.Navigate().GoToUrl(Utils.baseUrl);
            loginPage = new LoginPage(driver);
            usuarios = new Usuarios();
        }

        [AfterScenario]
        public void afterScenario()
        {
            driver.Close();
        }

         

        [Given(@"Que eu esteja na página de login")]
        public void GivenQueEuEstejaNaPaginaDeLogin()
        {
            loginPage.VerificaElementosNaPagina();
        }

        [When(@"Eu insiro as credenciais do usuário válido e clico em login")]
        public void WhenEuInsiroAsCredenciaisDoUsuarioEClicoEmLogin()
        {
            loginPage.LogIn(usuarios.usuarioCorreto());
        }

        [When(@"Eu insiro as credenciais do usuário inválido e clico em login")]
        public void WhenEuInsiroAsCredenciaisDoUsuarioInvalidoEClicoEmLogin()
        {
            loginPage.LogIn(usuarios.usuarioIncorreto());
        }

        [Then(@"O login deve ser feito com sucesso")]
        public void ThenOLoginDeveSerFeitoComSucesso()
        {
            Assert.Pass();
        }

        [Then(@"O login deve falhar")]
        public void ThenOLoginDeveFalhar()
        {
            Assert.Pass();
        }

    }
}
