using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private IWebElement Username => driver.FindElement(By.Id("txtUserName"));
    private IWebElement Password => driver.FindElement(By.Id("txtPassword"));
    private IWebElement LoginBtn => driver.FindElement(By.Id("btnLogin"));

    public void Login(string user, string pass)
    {
        Username.SendKeys(user);
        Password.SendKeys(pass);
        LoginBtn.Click();
    }
}
