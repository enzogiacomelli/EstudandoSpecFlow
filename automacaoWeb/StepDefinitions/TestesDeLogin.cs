namespace automacaoWeb.StepDefinitions
{
    [Binding]
    public class TestesDeLogin
    {
        private IWebDriver driver;
        Utils Utils = new Utils();
        PaginaDeLoginPO paginaDeLoginPO;
        Usuarios usuarios;


        [BeforeScenario]
        public void beforeScenario()
        {
            driver = NavegadorEdge.abrirNavegador();
            driver.Navigate().GoToUrl(Utils.base_Url);
            paginaDeLoginPO = new PaginaDeLoginPO(driver);
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
            paginaDeLoginPO.VerificaElementosNaPagina();
        }

        [When(@"Eu insiro as credenciais do usuário válido e clico em login")]
        public void WhenEuInsiroAsCredenciaisDoUsuarioEClicoEmLogin()
        {
            paginaDeLoginPO.LogIn(usuarios.usuarioCorreto());
        }

        [When(@"Eu insiro as credenciais do usuário inválido e clico em login")]
        public void WhenEuInsiroAsCredenciaisDoUsuarioInvalidoEClicoEmLogin()
        {
            paginaDeLoginPO.LogIn(usuarios.usuarioIncorreto());
        }

        [When(@"Eu insiro as credenciais do usuário bloqueado e clico em login")]
        public void WhenEuInsiroAsCredenciaisDoUsuarioBloqueadoEClicoEmLogin()
        {
            paginaDeLoginPO.LogIn(usuarios.usuarioBloqueado());
        }


        [Then(@"O login deve ser feito com sucesso")]
        public void ThenOLoginDeveSerFeitoComSucesso()
        {
            Assert.IsTrue(driver.Url.Equals(Utils.inventario_Url));
        }

        [Then(@"O login deve falhar")]
        public void ThenOLoginDeveFalhar()
        {
            paginaDeLoginPO.verificaMensagemDeErro();
        }

    }
}
