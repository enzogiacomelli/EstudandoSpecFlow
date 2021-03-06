namespace automacaoWeb.PageObjects
{
    public class PaginaDeLoginPO
    {
        private IWebDriver _driver;

        public PaginaDeLoginPO(IWebDriver driver) => _driver = driver;


        public IWebElement username => _driver.FindElement(By.Name("user-name"));
        public IWebElement password => _driver.FindElement(By.Name("password"));
        public IWebElement loginBtn => _driver.FindElement(By.Name("login-button"));
        public IWebElement alertaErro => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[3]/h3"));

        public void VerificaElementosNaPagina()
        {
            Assert.IsTrue(username.Displayed);
            Assert.IsTrue(password.Displayed);
            Assert.IsTrue(loginBtn.Displayed);
        }

        public void LogIn(Usuarios user)
        {
            username.SendKeys(user.nomeDeUsuario);
            password.SendKeys(user.senha);
            loginBtn.Click();
        }

        public void verificaMensagemDeErro()
        {
            Assert.IsTrue(alertaErro.Displayed);
        }
    }
}
