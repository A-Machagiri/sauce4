using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public By UsernameField => By.Id("user-name");
        public By PasswordField => By.Id("password");
        public By LoginButton => By.Id("login-button");
        public By ErrorMessage => By.CssSelector("[data-test='error']");
        // Product page locators for assertion after login
        public By ProductLabel => By.CssSelector(".product_label");
    }
}